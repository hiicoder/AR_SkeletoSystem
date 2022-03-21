using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPause : MonoBehaviour
{
    private VideoPlayer video;
    // Start is called before the first frame update
    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
    }
    public void PlayVideo()
    {
        video.Play();
    }
    public void PauseVideo()
    {
        video.Pause();
    }
}
