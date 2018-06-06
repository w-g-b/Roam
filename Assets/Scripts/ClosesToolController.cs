using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosesToolController : MonoBehaviour
{
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClickClosesTool()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
       
    }
}