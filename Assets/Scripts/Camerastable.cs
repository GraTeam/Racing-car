using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerastable : MonoBehaviour
{
    public int CarImport;
    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;
    public GameObject Car5;
    public GameObject Car6;


    public float CarX;
    public float CarY;
    public float CarZ;

    void Start()
    {
        CarImport = CarSelection.SelectedCar;
    }
        void Update()
    {
        if (CarImport == 1 || CarImport == 0)
        {
            CarX = Car1.transform.eulerAngles.x;
            CarY = Car1.transform.eulerAngles.y;
            CarZ = Car1.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }
        else if (CarImport == 2)
        {
            CarX = Car2.transform.eulerAngles.x;
            CarY = Car2.transform.eulerAngles.y;
            CarZ = Car2.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }
        else if (CarImport == 3)
        {
            CarX = Car3.transform.eulerAngles.x;
            CarY = Car3.transform.eulerAngles.y;
            CarZ = Car3.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }
        else if (CarImport == 4)
        {
            CarX = Car4.transform.eulerAngles.x;
            CarY = Car4.transform.eulerAngles.y;
            CarZ = Car4.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }
        else if (CarImport == 5)
        {
            CarX = Car5.transform.eulerAngles.x;
            CarY = Car5.transform.eulerAngles.y;
            CarZ = Car5.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }
        else if (CarImport == 6)
        {
            CarX = Car6.transform.eulerAngles.x;
            CarY = Car6.transform.eulerAngles.y;
            CarZ = Car6.transform.eulerAngles.z;

            transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        }

    }
}

