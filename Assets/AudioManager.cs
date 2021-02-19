using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject AudioLevel;

    void Start()
    {
        gameObject.SetActive(AudioLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
