using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
 
    public LayerMask isGrounded;
    bool sawOff;
    bool sawOn;
    bool animation;

    Animator animator;

    public float AngleOfContact;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        Rigidbody2D Sonic = GetComponent<Rigidbody2D>();

        

       

        bool attackKey = Input.GetAxisRaw("Fire1") == 1f;
        if (attackKey)
        {
 
            animator.SetBool("Saw", true);
        }



    }
}

