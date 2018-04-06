﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(3); // if press playGame open scene2
    }
    public void SelectTrack()
    {
        SceneManager.LoadScene(1);  // if press SelectTrack open scene1
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void MorningTrack()       //Below here are track selection buttons
    {
        SceneManager.LoadScene(2);
    }
    public void NightTrack()       
    {
        SceneManager.LoadScene(3);
    }
    public void DesertMorningTrack()
    {
        SceneManager.LoadScene(4);
    }
    public void DesertNightTrack()
    {
        SceneManager.LoadScene(5);
    }
    public void CityMorningTrack()
    {
        SceneManager.LoadScene(6);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
