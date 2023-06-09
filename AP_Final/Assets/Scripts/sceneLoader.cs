using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {
        if (sceneName.Equals("Level "))
        {
            int lev = PlayerPrefs.GetInt("Level");
            int continueLev = PlayerPrefs.GetInt("ContinueLevel");
            if (continueLev == lev)
            {
                continueLev = continueLev + 1;
                PlayerPrefs.SetInt("ContinueLevel", continueLev);
                PlayerPrefs.SetInt("canPlay" + continueLev.ToString(), 1);
            }
            lev += 1;
            PlayerPrefs.SetInt("Level", lev);
            PlayerPrefs.Save();
            SceneManager.LoadScene(sceneName + lev.ToString());
        } else if (sceneName.Equals("Game Over"))
        {
            int lev = PlayerPrefs.GetInt("Level");
            SceneManager.LoadScene("Level " + lev.ToString());
        }
        else if (sceneName.Equals("Continue"))
        {
            int level = PlayerPrefs.GetInt("ContinueLevel");
            SceneManager.LoadScene("Level " + level.ToString());
        }
        else if (sceneName.Contains("Select"))
        {
            int len = sceneName.Length;
            int x = len - 6;
            int level = Int32.Parse( sceneName.Substring(len - x));
            Debug.Log(level);
            PlayerPrefs.SetInt("Level", level);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Level " +level);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}