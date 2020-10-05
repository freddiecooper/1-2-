using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2move : MonoBehaviour
{
    // Start is called before the first frame update

    public int lives = 1;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey ("space"))
        {
            rb.velocity = new Vector3(0, 20, 0);
        }

        float xSpeed = -20.0f;
        

        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(-xSpeed * Time.deltaTime, 0, 0);
        }

        /*if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, -ySpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
        }*/


        if (Input.GetKey("x"))
        {
            lives = 0;
        }
    }
}