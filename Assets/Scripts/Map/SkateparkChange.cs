using UnityEngine;
using UnityEngine.SceneManagement;


public class SkateparkChange : MonoBehaviour
{
   public void Skatepark1() {
    SceneManager.LoadScene("SkateparkSteinergasse");
    Debug.Log("Button Pressed");
   }
}
