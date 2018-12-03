using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class GameControl : MonoBehaviour {

    
   
   

    public void StartGame(string sceneName)
    {
       
        SceneManager.LoadScene(sceneName);
    }

    

   

    public void ExitGame(string sceneName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    public void CancelExitGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ConfirmExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void RankButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CloseRank(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
