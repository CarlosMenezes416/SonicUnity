using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour { 


    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D Sonic = GetComponent<Rigidbody2D>();
        float hori = Input.GetAxis("Horizontal");
        
       

        if (hori > 0)
        {
            Sonic.velocity = new Vector2(speed, Sonic.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (hori < 0)
        {
            Sonic.velocity = new Vector2(speed * -1f, Sonic.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        } else
        {
            Sonic.velocity = new Vector2(0f, Sonic.velocity.y);
        }


        if (hori != 0f)
        {
            GetComponent<Animator>().SetBool("MOVING", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("MOVING", false);
        }


    }
}

