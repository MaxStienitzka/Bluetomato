using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGuide : MonoBehaviour {
    public void Button () {
        SceneManager.LoadScene ("Guide");
        Debug.Log ("Button Pressed");
    }
}