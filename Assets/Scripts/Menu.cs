using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Storage container;

    public Material StartDeck;

    public Material StartGrip;

    public Material StartRollers;

    public Material StartHanger;

    // void Start()
    // {
    //     container.Grip = StartGrip;
    //     container.Hanger = StartHanger;
    //     container.Rollers = StartRollers;
    //     container.Deck = StartDeck;
    // }
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Button Pressed");
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("Button2 Pressed");
    }

    public void SceneChange3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Debug.Log("Button3 Pressed");
    }

    public void Quit()
    {
        Debug.Log("Quit");
    }
    void Update()
{
    // Make sure user is on Android platform
    if (Application.platform == RuntimePlatform.Android) {
        
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
            // Quit the application
            Application.Quit();
        }
    }
}
}
