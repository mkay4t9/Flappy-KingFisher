using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverManager : MonoBehaviour
{
     public static bool gameOver;
     public static bool resume;
     public GameObject gameOverPannel;
     public GameObject resumePannel;

     private void Start() {
          gameOver = false;
          resume = false;
     }

     private void Update() {
          if(gameOver)
          {
               gameOverPannel.SetActive(true);
          }
          if(resume)
          {
               resumePannel.SetActive(true);
          }
          if(resume==false)
          {
               resumePannel.SetActive(false);
          }
          
     }
}
