using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BG_Music : MonoBehaviour {

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update () {
        if (SceneManager.GetActiveScene().name == "RaceArea01")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "RaceArea02")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "RaceArea03")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "RaceArea04")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "RaceArea05")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "RaceArea06")
        {
            Destroy(this.gameObject);
        }

    }
}
