using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject ball;
    public GameObject menu;
   
    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = new Vector3(40, 25, 0);
        Time.timeScale = 0f;
        menu.SetActive(true);

    }
}
