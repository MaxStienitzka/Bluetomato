using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    Vector3 minScale = new Vector3(1,1,1);
    Vector3 maxScale = new Vector3(3,3,3);

 
    void Update () {
    float zoomValue = Input.GetAxis("Mouse ScrollWheel");
 
    if (zoomValue != 0) {
             transform.localScale += Vector3.one * zoomValue;
             transform.localScale = Vector3.Max(transform.localScale, minScale);
             transform.localScale = Vector3.Min(transform.localScale, maxScale);
    }
 
    }

}
