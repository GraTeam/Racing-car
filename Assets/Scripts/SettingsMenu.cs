using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {
    public Toggle FullScreenToggle;
    public Slider VolumeSlider;
    public Dropdown QulaityDropdown;
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
        SetQuality(PlayerPrefs.GetInt("qualityVal", 1));
        SetResolution(PlayerPrefs.GetInt("resolution", 1));
        if (PlayerPrefs.GetInt("StoredFullBool") == 1)
        {
            FullScreenToggle.isOn = true;
        }

        if (PlayerPrefs.GetInt("StoredFullBool") == 0)
        {
            FullScreenToggle.isOn = false;
        }

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
        qualityIndex = QulaityDropdown.value;
        PlayerPrefs.SetInt("qualityVal",QulaityDropdown.value);
        PlayerPrefs.SetInt("quality",qualityIndex);
        PlayerPrefs.Save();
    }

    public void SetFullScreen(bool isFullscreen)
    {
        if (FullScreenToggle.isOn == true)
        {
            PlayerPrefs.SetInt("StoredFullBool", 1);
            Screen.fullScreen =  isFullscreen ;

        }
        if (FullScreenToggle.isOn == false)
        {
            PlayerPrefs.SetInt("StoredFullBool", 0);
            print("Going small");

            Screen.SetResolution(resolutions[0].width, resolutions[0].height, false);
        }

    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height ,Screen.fullScreen);
        PlayerPrefs.SetInt("resolution", resolutionIndex);
        PlayerPrefs.Save();
    }
}


