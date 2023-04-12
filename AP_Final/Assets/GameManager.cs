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
        if (level > 5 && level < 9)
        {
            SceneManager.LoadScene("gameOver Forest");
        } else if (level <= 5)
        {
            SceneManager.LoadScene("gameOver");
        } else if (level >= 9)
        {
            SceneManager.LoadScene("gameOver Lava");
        }
        
    }
}
