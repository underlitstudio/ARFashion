using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Menu : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject secondvid;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    void Start()
    {
        // Assign the VideoPlayer component from the GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        // Subscribe to the videoPlayer loopPointReached event
        videoPlayer.loopPointReached += OnVideoEndReached;
    }

    private void OnVideoEndReached(VideoPlayer vp)
    {
        // Video playback has reached the end
        //Debug.Log("Video has ended!");
        secondvid.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
