using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCar : MonoBehaviour {

    public int CarImport;
    public GameObject SelectCar1;
    public GameObject SelectCar2;
    public GameObject SelectCar3;
    public GameObject SelectCar4;
    public GameObject SelectCar5;
    public GameObject SelectCar6;


    void Start () {

        CarImport = CarSelection.SelectedCar;

        if (CarImport == 1)
        {
            SelectCar1.SetActive(true);
        }

        if (CarImport == 2)
        {
            SelectCar2.SetActive(true);
        }

    }
	
	
}
