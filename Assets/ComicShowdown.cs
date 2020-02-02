using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicShowdown : MonoBehaviour
{

    public GameObject Vomit1;
   
    public GameObject Vomit2;

    public GameObject Vomit3;
   
    public GameObject Vomit4;

    public GameObject ballero;

    //[HideInInspector]
    //public bool comic1, comic2, comic3, comic4 = false;

    private void Update()
    {
        /*comic1 = GetComponent<Movement>().c1;
        comic2 = GetComponent<Movement>().c2;
        comic3 = GetComponent<Movement>().c3;
        comic4 = GetComponent<Movement>().c4;*/
        vomitCheck();
    }
    void vomitCheck()
    {
        /*if(comic1 == true)
        {
            Comic1.SetActive(true);
        }
        if (comic2 == true)
        {
            Comic2.SetActive(true);
        }
        if (comic3 == true)
        {
            Comic3.SetActive(true);
        }
        if (comic4 == true)
        {
            Comic4.SetActive(true);
        }*/
        if (ballero.GetComponent<Movement>().Comic1 != null)
        {
            Vomit1.SetActive(true);
        }
        if (ballero.GetComponent<Movement>().Comic2 != null)
        {
            Vomit2.SetActive(true);
        }
        if (ballero.GetComponent<Movement>().Comic3 != null)
        {
            Vomit3.SetActive(true);
        }
        if (ballero.GetComponent<Movement>().Comic4 != null)
        {
            Vomit4.SetActive(true);
        }
    }
}
