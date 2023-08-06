using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class koding : MonoBehaviour
{
    public GameObject panel;
    public void Exitbutton()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Anaekran()
    {
        SceneManager.LoadScene(0);
    }
    public void MainMenu()
    {
        panel.gameObject.SetActive(true);
    }

    //public void RestartGame()
    //{

    //}
    
}
