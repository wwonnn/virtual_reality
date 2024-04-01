using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
public class ButtonController : MonoBehaviour
{
    public VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player.Stop();
    }

    void VideoPlay()
    {
        player.Play();
    }

    void VideoStop()
    {
        player.Stop();
    }

    public void OnClickPlay()
    {
        VideoPlay();
    }

    public void OnClickStop()
    {
        VideoStop();
    }
}
