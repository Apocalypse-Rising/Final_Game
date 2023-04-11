using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videoControl : MonoBehaviour
{
    float startTime;
    float currentTime;
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video.url = System.IO.Path.Combine("Assets/Imges/My Movie 31.mp4");
        video.Play();
        startTime = Time.time;
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime - startTime > 27)
        {
            SceneManager.LoadScene("Main Menu");
        }
        currentTime = Time.time;
    }
}
