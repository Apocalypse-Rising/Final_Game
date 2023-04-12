using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLvl : MonoBehaviour
{
    private sceneLoader loader;
    private float time;

    private void Start()
    {
        loader = gameObject.GetComponent<sceneLoader>();
        time = Time.deltaTime;
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision) { 
        if (collision.collider.tag == "Player")
        {
            if (gameObject.tag == "Ship")
            {
                PlayerPrefs.SetInt("canPlay10", 1);
                PlayerPrefs.Save();
                loader.LoadScene("Cutscene");
            }
            else
            {
                int level = PlayerPrefs.GetInt("Level");
                if (level >= 9)
                {
                    loader.LoadScene("endLevel Lava");
                } else if (level > 5 && level < 9) {
                    loader.LoadScene("endLevel Forest");
                }
                else
                {
                    loader.LoadScene("endLevel");
                }
                
            }
            
            PlayerPrefs.SetFloat("Time", time);
            PlayerPrefs.Save();
        }
    }
}
