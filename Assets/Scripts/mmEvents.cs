using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mmEvents : MonoBehaviour
{
    public GameObject quitPannel;
    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void quitScreen1()
    {
        quitPannel.SetActive(true);
    }

    public void yesQuit()
    {
        Application.Quit();
    }
    public void dontQuit()
    {
        quitPannel.SetActive(false);
    }
}
