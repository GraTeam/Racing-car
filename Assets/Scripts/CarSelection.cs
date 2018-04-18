using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelection : MonoBehaviour {

	public static int SelectedCar;
    public GameObject SelectCar1;
    public GameObject SelectCar2;
    public GameObject SelectCar3;
    public GameObject SelectCar4;
    public GameObject SelectCar5;
    public GameObject SelectCar6;



    public void Car1()
    {
        SelectedCar = 1;
        SelectCar1.SetActive(true);
        SelectCar2.SetActive(false);
        SelectCar3.SetActive(false);
        SelectCar4.SetActive(false);
        SelectCar5.SetActive(false);
        SelectCar6.SetActive(false);
    }

    public void Car2()
    {
        SelectedCar = 2;
        SelectCar2.SetActive(true);
        SelectCar1.SetActive(false);
        SelectCar3.SetActive(false);
        SelectCar4.SetActive(false);
        SelectCar5.SetActive(false);
        SelectCar6.SetActive(false);

    }

    public void Car3()
    {
        SelectedCar = 3;
        SelectCar3.SetActive(true);
        SelectCar1.SetActive(false);
        SelectCar2.SetActive(false);
        SelectCar4.SetActive(false);
        SelectCar5.SetActive(false);
        SelectCar6.SetActive(false);

    }

    public void Car4()
    {
        SelectedCar = 4;
        SelectCar4.SetActive(true);
        SelectCar1.SetActive(false);
        SelectCar2.SetActive(false);
        SelectCar3.SetActive(false);
        SelectCar5.SetActive(false);
        SelectCar6.SetActive(false);
    }

    public void Car5()
    {
        SelectedCar = 5;
        SelectCar5.SetActive(true);
        SelectCar1.SetActive(false);
        SelectCar2.SetActive(false);
        SelectCar3.SetActive(false);
        SelectCar4.SetActive(false);
        SelectCar6.SetActive(false);
    }

    public void Car6()
    {
        SelectedCar = 6;
        SelectCar6.SetActive(true);
        SelectCar1.SetActive(false);
        SelectCar2.SetActive(false);
        SelectCar3.SetActive(false);
        SelectCar4.SetActive(false);
        SelectCar5.SetActive(false);
    }


}
