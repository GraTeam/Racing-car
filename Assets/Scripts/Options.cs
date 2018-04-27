using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;


    //public void Restart()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
    public void SelectCar()
    {
        SceneManager.LoadScene(9);
    }
    public void SelectTrack()
    {
        SceneManager.LoadScene(1);  // if press SelectTrack open scene1
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void MorningTrack(int SceneIndex)       //Below here are track selection buttons
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
        //SceneManager.LoadScene(2);
    }
    IEnumerator LoadAsynchronously(int SceneIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = (int)progress * 100f + "%";

            yield return null;
        }
    }
    public void NightTrack(int SceneIndex)       
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
        //SceneManager.LoadScene(3);
    }
    public void DesertMorningTrack(int SceneIndex)
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
        //SceneManager.LoadScene(4);
    }
    public void DesertNightTrack(int SceneIndex)
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
        //SceneManager.LoadScene(5);
    }
    public void CityMorningTrack(int SceneIndex)
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
        //SceneManager.LoadScene(6);
    }
    public void CityNightTrack(int SceneIndex)
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
        //SceneManager.LoadScene(7);
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene(8);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

}
