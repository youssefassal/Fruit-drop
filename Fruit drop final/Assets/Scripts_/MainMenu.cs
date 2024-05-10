using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Cridits()
    {
        SceneManager.LoadScene("end");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
