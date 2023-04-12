using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class endCutscene : MonoBehaviour
{
    float startTime;
    float currentTime;
    private sceneLoader loader;
    private VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        currentTime = Time.time;
        loader = GetComponent<sceneLoader>();
        video = GetComponent<VideoPlayer>();
        video.url = System.IO.Path.Combine(Application.streamingAssetsPath, "My Movie 31.mp4");
        video.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime - startTime > 27)
        {
            loader.LoadScene("Main Menu");
        }
        currentTime = Time.time;
    }
}
