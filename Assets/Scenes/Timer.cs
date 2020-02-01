using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float timeLeft = 20.0f;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //float t = Time.time - startTime;

        //string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60).ToString("f1");

        //timer.text = minutes + ":" + seconds;
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Time.timeScale = 0f;
            endScreen.SetActive(true);
        }
        timer.text = timeLeft.ToString("f1");
        

    }
}
