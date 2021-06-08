using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class uiVideo : MonoBehaviour
{
    public VideoPlayer videoOrigin;
    private bool playing = false;

    private void PlayVideo()
    {
        videoOrigin.Play();
        playing = true;
    }

    private void PauseVideo()
    {
        videoOrigin.Pause();
        playing = false;
    }

    public void triggerVideo()
    {
        if (!playing)
        {
            PlayVideo();
        }
        else
        {
            PauseVideo();
        }
    }
}