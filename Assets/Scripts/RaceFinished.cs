using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinished : MonoBehaviour {

    public GameObject myCar;
    public GameObject Viewmodes;
    public GameObject FinishCamera;
    public GameObject music_of_game;
    public GameObject LapCompleteTrig;
    public AudioSource Finish_of_RaceMusic;
    public GameObject AICar;

    bool raceFinished = false;

    private void OnTriggerEnter()
    {
        if (raceFinished == false)
        {
            raceFinished = true;
            RaceFinish();
        }
    }

    void RaceFinish()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        myCar.SetActive(false);
        AICar.SetActive(false);
        LapCompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        myCar.GetComponent<CarController>().enabled = false;
        myCar.GetComponent<CarUserControl>().enabled = false;
        AICar.GetComponent<CarController>().enabled = false;
        AICar.GetComponent<CarAIControl>().enabled = false;
        myCar.SetActive(true);
        AICar.SetActive(true);
        myCar.GetComponent<CarAudio>().StopSound();
        myCar.GetComponent<CarAudio>().enabled = false;
        AICar.GetComponent<CarAudio>().StopSound();
        AICar.GetComponent<CarAudio>().enabled = false;
        FinishCamera.SetActive(true);
        music_of_game.SetActive(false);
        Viewmodes.SetActive(false);
        Finish_of_RaceMusic.Play();
    }
}
