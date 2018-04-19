using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlActive : MonoBehaviour {
    public int CarImport;
    public GameObject CarControl1;
    public GameObject CarControl2;
    public GameObject CarControl3;
    public GameObject CarControl4;
    public GameObject CarControl5;
    public GameObject CarControl6;

    public GameObject Dreamcar01;

    // Use this for initialization
    void Start () {
        CarImport = CarSelection.SelectedCar;
        if (CarImport == 1 || CarImport == 0)
        {
            CarControl1.GetComponent<CarUserControl>().enabled = true;
        }
        if (CarImport == 2)
        {
            CarControl2.GetComponent<CarUserControl>().enabled = true;
        }
        if (CarImport == 3)
        {
            CarControl3.GetComponent<CarUserControl>().enabled = true;
        }
        if (CarImport == 4)
        {
            CarControl4.GetComponent<CarUserControl>().enabled = true;
        }
        if (CarImport == 5)
        {
            CarControl5.GetComponent<CarUserControl>().enabled = true;
        }
        if (CarImport == 6)
        {
            CarControl6.GetComponent<CarUserControl>().enabled = true;
        }
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
		
	}
	
	
}
