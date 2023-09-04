using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void resume()
    {
        Time.timeScale = 0;
        GameOverManager.resume = true;
    }

    public void play()
    {
        GameOverManager.resume = false;
        Time.timeScale = 1;
    }
}
