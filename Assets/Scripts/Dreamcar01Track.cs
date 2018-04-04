using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcar01Track : MonoBehaviour {

    public GameObject TheMarker;
    public GameObject Mark01, Mark02, Mark03, Mark04, Mark05, Mark06, Mark07, Mark08, Mark09, Mark10,
        Mark11, Mark12, Mark13, Mark14, Mark15, Mark16, Mark17, Mark18, Mark19, Mark20, Mark21;
    public int MarkTracker;
	
	// Update is called once per frame
	void Update () {
        if(MarkTracker == 0)
        {
            TheMarker.transform.position = Mark01.transform.position;  
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Mark02.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Mark03.transform.position;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Mark04.transform.position;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Mark05.transform.position;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Mark06.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Mark07.transform.position;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = Mark08.transform.position;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = Mark09.transform.position;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = Mark10.transform.position;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = Mark11.transform.position;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = Mark12.transform.position;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Mark13.transform.position;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = Mark14.transform.position;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = Mark15.transform.position;
        }
        if (MarkTracker == 15)
        {
            TheMarker.transform.position = Mark16.transform.position;
        }
        if (MarkTracker == 16)
        {
            TheMarker.transform.position = Mark17.transform.position;
        }
        if (MarkTracker == 17)
        {
            TheMarker.transform.position = Mark18.transform.position;
        }
        if (MarkTracker == 18)
        {
            TheMarker.transform.position = Mark19.transform.position;
        }
        if (MarkTracker == 19)
        {
            TheMarker.transform.position = Mark20.transform.position;
        }
        if (MarkTracker == 20)
        {
            TheMarker.transform.position = Mark21.transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if(MarkTracker == 21)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
