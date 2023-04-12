using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    // Start is called before the first frame update
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Restart();
        }
        
    }

    void Restart()
    {
        int level = PlayerPrefs.GetInt("Level");
        Debug.Log(level);
        if (level > 6 && level < 10)
        {
            SceneManager.LoadScene("gameOver Forest");
        } else if (level <= 6)
        {
            SceneManager.LoadScene("gameOver");
        } else if (level >= 10)
        {
            SceneManager.LoadScene("gameOver Lava");
        }
        
    }
}
