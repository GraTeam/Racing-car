using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject NormalCamera;
    public GameObject FarCamera;
    public GameObject FPCamera;
    public int CamMode;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if(CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(ModeChange());   //فى ال WaitForSeconds انت بتنفذها علطول و تستنى النتيجه بتاتها ولكن لا يمكنك ايقافها فى اى وقت..لكن الفناكشن التنفيذيه StartCoroutine لما بتبدأ تنفيذها تقدر توقف التنفيذ فى اى وقت بمجرد كتابه Yield فقط !


        }

    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0)
        {
            NormalCamera.SetActive(true);
            FPCamera.SetActive(false);
        }
        if(CamMode == 1)
        {
            FarCamera.SetActive(true);
            NormalCamera.SetActive(false);
        }
        if(CamMode == 2)
        {
            FPCamera.SetActive(true);
            FarCamera.SetActive(false);
        }
    }
}
