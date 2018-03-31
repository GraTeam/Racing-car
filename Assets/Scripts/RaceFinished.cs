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

    void OnTiggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        myCar.SetActive(false);
        LapCompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        myCar.GetComponent<CarController>().enabled = false;
        myCar.GetComponent<CarUserControl>().enabled = false;
        myCar.SetActive(true);
        FinishCamera.SetActive(true);
        music_of_game.SetActive(false);
        Viewmodes.SetActive(false);
        Finish_of_RaceMusic.Play();
    }
}
