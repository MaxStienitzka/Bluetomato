using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu3 : MonoBehaviour {
    public void SceneChange2 () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 3);
        Debug.Log ("Button Pressed");
    }
}