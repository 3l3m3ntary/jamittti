using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    Vector3 direction;

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
        if (Input.GetKeyDown("l"))
        {
            direction = Vector3.forward;
        }
    
        else if (Input.GetKeyDown("a"))
        {
           direction = Vector3.back;
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Comic1"))
        {
            Comic1 = collision.gameObject;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Comic2"))
        {
            Comic2 = collision.gameObject;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Comic3"))
        {
            Comic3 = collision.gameObject;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Comic4"))
        {
            Comic4 = collision.gameObject;
            collision.gameObject.SetActive(false);
        }
    }
}
