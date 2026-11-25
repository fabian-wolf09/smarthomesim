using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TabletManager : MonoBehaviour
{
    [Header("Screens / Panels")]
    [SerializeField] private GameObject homeScreenPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject camerasPanel;
    [SerializeField] private GameObject placingPanel;
    [SerializeField] private GameObject deviceHubPanel;

    [Header("Top Bar Elements")]
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private Image weatherIcon;
    [SerializeField] private TMP_Text temperatureText;

    [Header("Time Speed Button")]
    [Tooltip("Optional: Text auf dem Button, der die aktuelle Geschwindigkeit anzeigt")]
    [SerializeField] private TMP_Text timeSpeedText;

    [Tooltip("Optional: Image auf dem Button, das das passende 0x/1x/2x/8x-Icon anzeigt")]
    [SerializeField] private Image timeSpeedIcon;

    [Header("Environment")]
    [Tooltip("Leer lassen = wird automatisch über EnviromentManager.Instance gesucht")]
    [SerializeField] private EnviromentManager environment;

    private GameObject currentActivePanel;

    private void Start()
    {
        SwitchPanel(homeScreenPanel);

        if (environment == null) environment = EnviromentManager.Instance;
        if (environment == null) environment = FindFirstObjectByType<EnviromentManager>();

        if (environment == null)
        {
            Debug.LogError("[TabletManager] Kein EnviromentManager in der Szene gefunden.");
            return;
        }

        environment.OnTimeChanged += UpdateTime;
        environment.OnWeatherChanged += UpdateWeather;
        environment.OnTimeSpeedChanged += UpdateTimeSpeed;

        UpdateTime();
        UpdateWeather();
        UpdateTimeSpeed();
    }

    private void OnDestroy()
    {
        if (environment == null) return;
        environment.OnTimeChanged -= UpdateTime;
        environment.OnWeatherChanged -= UpdateWeather;
        environment.OnTimeSpeedChanged -= UpdateTimeSpeed;
    }

    public void OpenSettings() => SwitchPanel(settingsPanel);
    public void OpenCameras() => SwitchPanel(camerasPanel);
    public void OpenPlacing() => SwitchPanel(placingPanel);
    public void OpenDeviceHub() => SwitchPanel(deviceHubPanel);
    public void ReturnToHomeScreen() => SwitchPanel(homeScreenPanel);

    private void SwitchPanel(GameObject targetPanel)
    {
        if (homeScreenPanel != null) homeScreenPanel.SetActive(false);
        if (settingsPanel != null) settingsPanel.SetActive(false);
        if (camerasPanel != null) camerasPanel.SetActive(false);
        if (placingPanel != null) placingPanel.SetActive(false);
        if (deviceHubPanel != null) deviceHubPanel.SetActive(false);

        if (targetPanel != null)
        {
            targetPanel.SetActive(true);
            currentActivePanel = targetPanel;
        }
    }

    public void CycleTimeSpeed()
    {
        if (environment != null) environment.CycleTimeSpeed();
    }

    public void SetTimeSpeedIndex(int index)
    {
        if (environment != null) environment.SetTimeSpeedIndex(index);
    }

    public void SetTimeSpeed(float speed)
    {
        if (environment != null) environment.SetTimeSpeed(speed);
    }

    private void UpdateTime()
    {
        if (timeText != null)
        {
            timeText.text = environment.GetFormattedTime();
        }
    }

    private void UpdateWeather()
    {
        if (weatherIcon != null)
        {
            Sprite icon = environment.GetWeatherIcon();
            if (icon != null) weatherIcon.sprite = icon;
        }
        if (temperatureText != null)
        {
            temperatureText.text = environment.GetFormattedTemperature();
        }
    }

    private void UpdateTimeSpeed()
    {
        if (timeSpeedText != null)
        {
            timeSpeedText.text = environment.GetTimeSpeedLabel();
        }
        if (timeSpeedIcon != null)
        {
            Sprite icon = environment.GetTimeSpeedIcon();
            if (icon != null) timeSpeedIcon.sprite = icon;
        }
    }
}
