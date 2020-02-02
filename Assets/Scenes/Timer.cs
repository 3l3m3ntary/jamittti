using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float timeLeft = 20.0f;
    public GameObject endScreen;
    public GameObject playa;
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
            timeLeft = 0;
            playa.GetComponent<Movement>().rb.constraints = RigidbodyConstraints.FreezeAll;

            endScreen.SetActive(true);
            //Time.timeScale = 0f;
        }
        timer.text = timeLeft.ToString("f1");
        

    }
}
