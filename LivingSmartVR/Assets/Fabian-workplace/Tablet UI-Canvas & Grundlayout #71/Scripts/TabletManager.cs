using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TabletManager : MonoBehaviour
{
    [Header("Screens / Panels")]
    [SerializeField] private GameObject homeScreenPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject camerasPanel;
    [SerializeField] private GameObject devicesPanel;
    [SerializeField] private GameObject deviceHubPanel;

    [Header("Top Bar Elements")]
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private Image weatherIcon;
    [SerializeField] private TMP_Text temperatureText;

    private GameObject currentActivePanel;

    private void Start()
    {
        SwitchPanel(homeScreenPanel);
    }




    public void OpenSettings() => SwitchPanel(settingsPanel);
    public void OpenCameras() => SwitchPanel(camerasPanel);
    public void OpenDevices() => SwitchPanel(devicesPanel);
    public void OpenDeviceHub() => SwitchPanel(deviceHubPanel);

    private void SwitchPanel(GameObject targetPanel)
    {
        if (homeScreenPanel != null) homeScreenPanel.SetActive(false);
        if (settingsPanel != null) settingsPanel.SetActive(false);
        if (camerasPanel != null) camerasPanel.SetActive(false);
        if (devicesPanel != null) devicesPanel.SetActive(false);
        if (deviceHubPanel != null) deviceHubPanel.SetActive(false);

        if (targetPanel != null)
        {
            targetPanel.SetActive(true);
            currentActivePanel = targetPanel;
        }
    }

    public void UpdateClock(int hours, int minutes)
    {
        if (timeText != null)
        {
            timeText.text = $"{hours:00}:{minutes:00}";
        }
    }
    
    public void UpdateWeather(string iconName, float temperature)
    {
        Sprite icon = Resources.Load<Sprite>($"Assets/Fabian-workplace/Tablet UI-Canvas & Grundlayout #71/Images/Icons/{iconName}" + ".png");
        if (weatherIcon != null)
        {
            weatherIcon.sprite = icon;
        }
        if (temperatureText != null)
        {
            temperatureText.text = $"{temperature:0}°C";
        }
    }
}