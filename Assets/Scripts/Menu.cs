using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    public void StartTest()
    {
        SceneManager.LoadScene("Test 1");   
    }

    public void ExitGame()
    {
        Application.Quit();

         #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
