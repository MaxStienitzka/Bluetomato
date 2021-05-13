using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoatetItem : MonoBehaviour
{
    public float RotateSkateboard;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * 0, RotateSkateboard, 0));
    }
}
