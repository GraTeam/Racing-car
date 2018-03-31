using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

    public int MinuteCount;
    public int SecondCount;
    public float MilliCount;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    // Use this for initialization
    void Start ()
    {
        //display saved time

        MinuteCount = PlayerPrefs.GetInt("SaveMinutes");
        SecondCount = PlayerPrefs.GetInt("SaveSeconds");
        MilliCount = PlayerPrefs.GetInt("SaveMilliseconds");

        MinuteDisplay.GetComponent<Text>().text = "" + MinuteCount + ":";
        SecondDisplay.GetComponent<Text>().text = "" + SecondCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;

		
	}
	
	
}
