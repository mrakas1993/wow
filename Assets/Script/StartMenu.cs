using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("StartLocation");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
