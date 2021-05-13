using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectGuide : MonoBehaviour
{

  public void SelectGuideGriptape () 
  {  
      SceneManager.LoadScene("GripTape");
        Debug.Log ("Button Pressed");  
       
  }

   public void SelectGuideKugellager() {
    
       
         SceneManager.LoadScene("Kugellager");
        Debug.Log ("Button Pressed");  
       }
  

   public void SelectGuideTricks () {
      
    
         SceneManager.LoadScene("Tricks");
        Debug.Log ("Button Pressed");  
       
  }

   public void SelectGuidePersonalisieren () {
      
       
         SceneManager.LoadScene("Customizer");
        Debug.Log ("Button Pressed");  
       
  }
}