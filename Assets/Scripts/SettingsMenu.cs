using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public Dropdown ResolutionDropdown;
    Resolution[] resolutions;


    void Start()
    {
        resolutions = Screen.resolutions;
        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
         
        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = currentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();
        SetVolume(PlayerPrefs.GetFloat("volume", 10f));
        SetQuality(PlayerPrefs.GetInt("quality",1));
        SetResolution(PlayerPrefs.GetInt("resolution", 1));
    }

	public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume);
        PlayerPrefs.SetFloat("volume",volume);
        PlayerPrefs.Save();
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("quality",qualityIndex);
        PlayerPrefs.Save();
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height ,Screen.fullScreen);
        PlayerPrefs.SetInt("resolution", resolutionIndex);
        PlayerPrefs.Save();
    }
}


