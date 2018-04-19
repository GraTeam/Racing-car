using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinished : MonoBehaviour {

    public int CarImport;
    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;
    public GameObject Car5;
    public GameObject Car6;
    public GameObject Viewmodecar1;
    public GameObject Viewmodecar2;
    public GameObject Viewmodecar3;
    public GameObject Viewmodecar4;
    public GameObject Viewmodecar5;
    public GameObject Viewmodecar6;
    public GameObject FinishCamera1;
    public GameObject FinishCamera2;
    public GameObject FinishCamera3;
    public GameObject FinishCamera4;
    public GameObject FinishCamera5;
    public GameObject FinishCamera6;
    public GameObject music_of_game;
    public GameObject LapCompleteTrig;
    public AudioSource Finish_of_RaceMusic;
    public GameObject AICar;

    bool raceFinished = false;

    void Start()
    {
        CarImport = CarSelection.SelectedCar;
    }
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
        if (CarImport == 1 || CarImport == 0)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Car1.SetActive(false);
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car1.GetComponent<CarController>().enabled = false;
            Car1.GetComponent<CarUserControl>().enabled = false;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            Car1.SetActive(true);
            AICar.SetActive(true);
            Car1.GetComponent<CarAudio>().StopSound();
            Car1.GetComponent<CarAudio>().enabled = false;
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            FinishCamera1.SetActive(true);
            music_of_game.SetActive(false);
            Viewmodecar1.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
        if (CarImport == 2)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Car2.SetActive(false);
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car2.GetComponent<CarController>().enabled = false;
            Car2.GetComponent<CarUserControl>().enabled = false;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            Car2.SetActive(true);
            AICar.SetActive(true);
            Car2.GetComponent<CarAudio>().StopSound();
            Car2.GetComponent<CarAudio>().enabled = false;
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            FinishCamera2.SetActive(true);
            music_of_game.SetActive(false);
            Viewmodecar2.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
        if (CarImport == 3)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Car3.SetActive(false);
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car3.GetComponent<CarController>().enabled = false;
            Car3.GetComponent<CarUserControl>().enabled = false;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            Car3.SetActive(true);
            AICar.SetActive(true);
            Car3.GetComponent<CarAudio>().StopSound();
            Car3.GetComponent<CarAudio>().enabled = false;
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            FinishCamera3.SetActive(true);
            music_of_game.SetActive(false);
            Viewmodecar3.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
        if (CarImport == 4)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Car4.SetActive(false);
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car4.GetComponent<CarController>().enabled = false;
            Car4.GetComponent<CarUserControl>().enabled = false;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            Car4.SetActive(true);
            AICar.SetActive(true);
            Car4.GetComponent<CarAudio>().StopSound();
            Car4.GetComponent<CarAudio>().enabled = false;
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            FinishCamera4.SetActive(true);
            music_of_game.SetActive(false);
            Viewmodecar4.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
        if (CarImport == 5)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Car5.SetActive(false);
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car5.GetComponent<CarController>().enabled = false;
            Car5.GetComponent<CarUserControl>().enabled = false;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            Car5.SetActive(true);
            AICar.SetActive(true);
            Car5.GetComponent<CarAudio>().StopSound();
            Car5.GetComponent<CarAudio>().enabled = false;
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            FinishCamera5.SetActive(true);
            music_of_game.SetActive(false);
            Viewmodecar5.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
        if (CarImport == 6)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Car6.SetActive(false);
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car6.GetComponent<CarController>().enabled = false;
            Car6.GetComponent<CarUserControl>().enabled = false;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            Car6.SetActive(true);
            AICar.SetActive(true);
            Car6.GetComponent<CarAudio>().StopSound();
            Car6.GetComponent<CarAudio>().enabled = false;
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            FinishCamera6.SetActive(true);
            music_of_game.SetActive(false);
            Viewmodecar6.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            AICar.SetActive(false);
            LapCompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            AICar.GetComponent<CarController>().enabled = false;
            AICar.GetComponent<CarAIControl>().enabled = false;
            AICar.SetActive(true);
            AICar.GetComponent<CarAudio>().StopSound();
            AICar.GetComponent<CarAudio>().enabled = false;
            music_of_game.SetActive(false);
            Finish_of_RaceMusic.Play();
        }
    }
}
