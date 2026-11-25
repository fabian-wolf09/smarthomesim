using System;
using UnityEngine;

public enum WeatherCondition { Clear, Cloudy, Rain }

public class EnviromentManager : MonoBehaviour
{
    public static EnviromentManager Instance { get; private set; }

    [Header("Time Simulation")]
    [Tooltip("Startuhrzeit (Stunde) beim Spielstart")]
    [Range(0, 23)]
    [SerializeField] private int startHour = 6;

    [Tooltip("Wie viele echte Minuten ein simulierter Tag (24h) bei 1x dauert")]
    [SerializeField] private float realMinutesPerDayAt1x = 10f;

    [Tooltip("Verfügbare Geschwindigkeiten, durch die geschaltet wird")]
    [SerializeField] private float[] timeSpeeds = { 0f, 1f, 2f, 8f };

    [Tooltip("Index der Startgeschwindigkeit in timeSpeeds (1 = 1x)")]
    [SerializeField] private int currentSpeedIndex = 1;

    [Header("Day / Night")]
    [Range(0, 23)] [SerializeField] private int dayStartHour = 6;
    [Range(0, 23)] [SerializeField] private int nightStartHour = 20;

    [Header("Weather Simulation")]
    [Tooltip("Alle wie viele simulierte Stunden das Wetter aktualisiert wird")]
    [SerializeField] private int weatherUpdateIntervalHours = 3;
    [SerializeField] private float minTemperature = -10f;
    [SerializeField] private float maxTemperature = 35f;

    [Header("Icons")]
    [SerializeField] private string iconFolder = "Icons";

    public event Action OnTimeChanged;
    public event Action OnWeatherChanged;
    public event Action OnTimeSpeedChanged;

    public int SimulatedMinutes => simulatedMinutes;
    public int Hours => simulatedMinutes / 60;
    public int Minutes => simulatedMinutes % 60;
    public float TimeSpeed => timeSpeeds[currentSpeedIndex];
    public int TimeSpeedIndex => currentSpeedIndex;
    public bool IsNight => Hours < dayStartHour || Hours >= nightStartHour;
    public WeatherCondition CurrentWeather => currentCondition;
    public float Temperature => currentTemperature;

    private int simulatedMinutes;
    private float timeAccumulator;
    private int weatherUpdateBlock = -1;
    private bool lastIsNight;
    private WeatherCondition currentCondition;
    private float currentTemperature;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogWarning("[EnviromentManager] Es gibt mehr als einen EnviromentManager in der Szene.");
        }
        Instance = this;

        currentSpeedIndex = Mathf.Clamp(currentSpeedIndex, 0, timeSpeeds.Length - 1);
        simulatedMinutes = startHour * 60;
        lastIsNight = IsNight;
        RollWeather();
        weatherUpdateBlock = CurrentWeatherBlock();
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    private void Update()
    {
        TimeSim();
        WeatherSim();
    }

    private void TimeSim()
    {
        float speed = TimeSpeed;
        if (speed <= 0f) return;

        float secondsPerSimMinute = (realMinutesPerDayAt1x * 60f) / 1440f;

        timeAccumulator += Time.deltaTime * speed;

        bool changed = false;
        while (timeAccumulator >= secondsPerSimMinute)
        {
            timeAccumulator -= secondsPerSimMinute;
            simulatedMinutes = (simulatedMinutes + 1) % 1440;
            changed = true;
        }

        if (changed) OnTimeChanged?.Invoke();
    }

    public void CycleTimeSpeed()
    {
        SetTimeSpeedIndex((currentSpeedIndex + 1) % timeSpeeds.Length);
    }

    public void SetTimeSpeedIndex(int index)
    {
        currentSpeedIndex = Mathf.Clamp(index, 0, timeSpeeds.Length - 1);
        OnTimeSpeedChanged?.Invoke();
    }

    public void SetTimeSpeed(float speed)
    {
        int index = Array.IndexOf(timeSpeeds, speed);
        if (index < 0)
        {
            Debug.LogWarning($"[EnviromentManager] Zeitfaktor {speed}x ist nicht in timeSpeeds vorhanden.");
            return;
        }
        SetTimeSpeedIndex(index);
    }

    public string GetFormattedTime() => $"{Hours:00}:{Minutes:00}";

    public string GetFormattedTemperature() => $"{Temperature:0}°C";

    public string GetTimeSpeedLabel() => GetTimeSpeedLabel(TimeSpeed);

    public static string GetTimeSpeedLabel(float speed) => $"{speed:0}x";

    public string GetTimeSpeedIconName() => GetTimeSpeedLabel();

    public Sprite GetTimeSpeedIcon() => LoadIcon(GetTimeSpeedIconName());

    public string GetWeatherIconName() => GetWeatherIconName(currentCondition, IsNight);

    public static string GetWeatherIconName(WeatherCondition condition, bool isNight)
    {
        switch (condition)
        {
            case WeatherCondition.Clear:  return isNight ? "moon" : "sun";
            case WeatherCondition.Cloudy: return isNight ? "cloud-moon" : "cloud-sun";
            case WeatherCondition.Rain:   return "cloud-rain";
            default:                      return "sun";
        }
    }

    public Sprite GetWeatherIcon() => LoadIcon(GetWeatherIconName());

    private Sprite LoadIcon(string iconName)
    {
        string path = $"{iconFolder}/{iconName}";
        Sprite sprite = Resources.Load<Sprite>(path);
        if (sprite == null)
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>(path);
            if (sprites.Length > 0) sprite = sprites[0];
        }
        if (sprite == null)
        {
            Debug.LogWarning($"[EnviromentManager] Icon nicht gefunden: Resources/{path}");
        }
        return sprite;
    }

    private void WeatherSim()
    {
        bool isNight = IsNight;
        int block = CurrentWeatherBlock();
        bool newBlock = block != weatherUpdateBlock;

        if (newBlock)
        {
            weatherUpdateBlock = block;
            RollWeather();
        }

        if (newBlock || isNight != lastIsNight)
        {
            lastIsNight = isNight;
            OnWeatherChanged?.Invoke();
        }
    }

    private int CurrentWeatherBlock()
    {
        return simulatedMinutes / (Mathf.Max(1, weatherUpdateIntervalHours) * 60);
    }

    private void RollWeather()
    {
        currentTemperature = UnityEngine.Random.Range(minTemperature, maxTemperature);
        currentCondition = (WeatherCondition)UnityEngine.Random.Range(0, Enum.GetValues(typeof(WeatherCondition)).Length);
    }
}
