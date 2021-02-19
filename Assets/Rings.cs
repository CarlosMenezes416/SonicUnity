using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rings : MonoBehaviour
{
    public AudioClip RingSound;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<AudioSource>().PlayOneShot(RingSound);
            GetComponent<Animator>().SetBool("ringstars", true);
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}