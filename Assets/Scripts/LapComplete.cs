using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject RoundsCounter;
    public int RoundsDone;
    public int RoundsDoneAI;
    public float RowTime;
    public GameObject RaceFinish;
    public GameObject Lose;
    public GameObject Win;


    // Update is called once per frame
    void Update()
    {
        if(RoundsDone == 2)
        {
            RaceFinish.SetActive(true);
            Win.SetActive(true);
        }
        if (RoundsDoneAI == 2)
        {
            RaceFinish.SetActive(true);
            Lose.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RoundsDone += 1;
            RowTime = PlayerPrefs.GetFloat("RowTime");
            if (LapTimeManager.RowTime <= RowTime)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";

                }


                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";

                }



                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

            }


            PlayerPrefs.SetInt("SaveMinutes", LapTimeManager.MinuteCount); //save time of player
            PlayerPrefs.SetInt("SaveSeconds", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("SaveMilliseconds", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("RowTime", LapTimeManager.RowTime);


            //save time then set timer to 0 ;
            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RowTime = 0;

            RoundsCounter.GetComponent<Text>().text = "" + RoundsDone;


            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
        if (collision.gameObject.tag == "Dreamcar01")
        {
            RoundsDoneAI += 1;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
