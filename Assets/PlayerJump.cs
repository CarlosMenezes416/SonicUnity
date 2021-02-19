using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public AudioClip AudioPulo;
    public LayerMask isGrounded;
    public Transform GroundChecker;
    bool isFloored;
    bool isJumping;
    bool animation;
    public float JumpStrength;
    public float AngleOfContact;


    void Update()
    {
        Rigidbody2D Sonic = GetComponent<Rigidbody2D>();
        isFloored = Physics2D.OverlapCircle(GroundChecker.position,
                                            AngleOfContact,
                                            isGrounded);
        if(isFloored)
        {
            animation = true;
        }
        else
        {
            animation = false;
        }
        if(animation)
        {
            GetComponent<Animator>().SetBool("Jump", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Jump", true);
            GetComponent<Animator>().SetBool("MOVING", false);

        }

        if (Input.GetButtonDown("Jump") && isFloored)
        {
            isJumping = true;
            GetComponent<AudioSource>().PlayOneShot(AudioPulo);
        }
        if (isJumping)
        {
            Sonic.AddForce(new Vector2(0, JumpStrength));
            isJumping = false;
        }
    }


}
