using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    private VideoPlayer vidoePlayer;
    private bool isPlay = false;

    private void Awake()
    {
        vidoePlayer = GetComponent<VideoPlayer>();
    }

    public void OnClickTV()
    {
        if (isPlay)
        {
            vidoePlayer.Pause();
            isPlay = false;
        }
        else
        {
            vidoePlayer.Play();
            isPlay = true;
        }
    }
}