using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlActive : MonoBehaviour {
    public int CarImport;
    public GameObject CarControl1;
    public GameObject CarControl2;
    public GameObject Dreamcar01;

    // Use this for initialization
    void Start () {
        CarImport = CarSelection.SelectedCar;
        if (CarImport == 1)
        {
            CarControl1.GetComponent<CarUserControl>().enabled = true;
        }
        if (CarImport == 2)
        {
            CarControl2.GetComponent<CarUserControl>().enabled = true;
        }
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
		
	}
	
	
}
