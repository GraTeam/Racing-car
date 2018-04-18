using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerastable : MonoBehaviour
{
    public int CarImport;
    public GameObject Car1;
    public GameObject Car2;
    public float CarX;
    public float CarY;
    public float CarZ;

    void Start()
    {
        CarImport = CarSelection.SelectedCar;
    }
        void Update()
    {
        if (CarImport == 1)
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

    }
}

