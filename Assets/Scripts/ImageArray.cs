using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageArray : MonoBehaviour
{
    public Image MyImage;

    public Sprite[] ImageList;

    private int ArrayPos = 0;

    public int secondsTobeWaited;

    void Start()
    {
        StartCoroutine(loop());
    }

    public void NextImage()
    {
        if (ArrayPos >= ImageList.Length - 1)
        {
            ArrayPos = 0;
        }
        else
        {
            ArrayPos += 1;
        }
    }

    public void LastImage()
    {
        if (ArrayPos > 0)
        {
            ArrayPos -= 1;
        }
    }

    void Update()
    {
        MyImage.sprite = ImageList[ArrayPos];
    }

    IEnumerator loop()
    {
        while (true)
        {
            yield return new WaitForSeconds(secondsTobeWaited);
            ArrayPos += 1;
            if (ArrayPos >= ImageList.Length)
            {
                ArrayPos = 0;
            }
        }
    }
}
