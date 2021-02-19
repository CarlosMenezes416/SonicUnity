using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        Sonic.velocity = new Vector2(hori * speed, Sonic.velocity.y);

        if (hori > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (hori < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }


        if (hori > 0 || hori < 0)
        {
            GetComponent<Animator>().SetBool("MOVING", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("MOVING", false);
        }



    }
}

