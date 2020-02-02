using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    Vector3 direction;
    //public bool c1, c2, c3, c4 = false;


    public GameObject Comic1, Comic2, Comic3, Comic4;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetInput();
        rb.AddForce(direction * speed);

        
    }

    void GetInput()
    {
        if (Input.GetKeyUp("l"))
        {
            direction = Vector3.forward.normalized;
        }
    
        else if (Input.GetKeyUp("a"))
        {
           direction = Vector3.back.normalized;
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Comic1"))
        {
            Comic1 = collision.gameObject;
            collision.gameObject.SetActive(false);
            //c1 = true;
        }
        if (collision.gameObject.CompareTag("Comic2"))
        {
            Comic2 = collision.gameObject;
            collision.gameObject.SetActive(false);
            //c2 = true;
        }
        if (collision.gameObject.CompareTag("Comic3"))
        {
            Comic3 = collision.gameObject;
            collision.gameObject.SetActive(false);
            //c3 = true;
        }
        if (collision.gameObject.CompareTag("Comic4"))
        {
            Comic4 = collision.gameObject;
            collision.gameObject.SetActive(false);
            //c4 = true;
        }
    }
}
