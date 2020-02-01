using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    Vector3 direction;



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
        if (Input.GetKeyDown("d"))
        {
            direction = Vector3.forward;
        }
        else if(Input.GetKeyUp("d"))
        {
           // rb.velocity = Vector3.zero;
        }
        else if (Input.GetKeyDown("a"))
        {
           direction = Vector3.back;
        }
        else if (Input.GetKeyUp("a"))
        {
           // rb.velocity = Vector3.zero;
        }
    }
}
