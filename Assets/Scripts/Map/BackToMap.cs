using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMap : MonoBehaviour
{
    public void SceneChangeMap()
    {
        SceneManager.LoadScene("Map");
        Debug.Log("Button Pressed");
    }
}
