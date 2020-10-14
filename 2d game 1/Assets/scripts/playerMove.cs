using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer sr;
    public Sprite standSprite;
    public Sprite jumpSprite;
    public int lives = 1;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        
        
        if(Input.GetKeyDown ("up"))
        {           
            if(velocity.y == 0)
            {
                velocity.y = 40;
            }
        } 
          
        if (Input.GetKey("left"))
        {
            velocity.x = -10;
        }     
         

        if (Input.GetKey("right"))
        {
            velocity.x = 10;
        }
        rb.velocity = velocity;


        if (Input.GetKey("x"))
        {
            lives = 0;
        } 


        if (velocity.y > 0.01f)
        {
            sr.sprite = jumpSprite;
        }

        else
        {
            sr.sprite = standSprite;
        }
          
    }
}

