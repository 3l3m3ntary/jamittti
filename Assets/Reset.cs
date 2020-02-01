using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject ball;
    

    void Update()
    {
     
    }
    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = new Vector3(40, 25, 0);
    }
}
