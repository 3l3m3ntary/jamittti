using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPose : MonoBehaviour
{
    public GameObject ball;
    public GameObject VP;

    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = new Vector3(40, 25, 0);
        VP.SetActive(true);
        Time.timeScale = 0f;

    }
}
