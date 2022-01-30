using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene(1);
       Debug.Log("Touch");
   }

   public void CloseGame()
   {
       SceneManager.LoadScene(0);
   }

   public void ExitGame()
   {
       Application.Quit();
   }
}
