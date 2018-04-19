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

        if (CarImport == 1 || CarImport == 0)
        {
            SelectCar1.SetActive(true);
        }

        if (CarImport == 2)
        {
            SelectCar2.SetActive(true);
        }

        if (CarImport == 3)
        {
            SelectCar3.SetActive(true);
        }

        if (CarImport == 4)
        {
            SelectCar4.SetActive(true);
        }

        if (CarImport == 5)
        {
            SelectCar5.SetActive(true);
        }

        if (CarImport == 6)
        {
            SelectCar6.SetActive(true);
        }

    }
	
	
}
