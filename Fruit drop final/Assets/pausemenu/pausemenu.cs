using System.Timers;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour

{

 [SerializeField] GameObject pauseMenu;
 public void Pause ()
 {
    pauseMenu.SetActive(true);


 }

 public void Home()
 {
    SceneManager.LoadScene("MainMenu");

 }
 public void Resume()
 {
    pauseMenu.SetActive(false);



 }
 public void Restart()
 {


    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 }


}
