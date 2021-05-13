// using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using System.Collections.IEnumerable;
public class ChangeImage : MonoBehaviour
{
    public Image MyImage;

    public Sprite Image_1;

    public Sprite Image_2;

    public Sprite Image_3;

    private bool ImageTrue;

    private void Update()
    {
    }

    void Start()
    {
        StartCoroutine(loop());
    }

    public void SetImageOne()
    {
        MyImage.sprite = Image_1;
    }

    public void SetImageTwo()
    {
        MyImage.sprite = Image_2;
    }

    public void SetImageThree()
    {
        MyImage.sprite = Image_3;
    }

    public void ImageChange()
    {
        if (MyImage.sprite = Image_1)
        {
            SetImageTwo();
        }
    }

    IEnumerator loop()
    {
        while (true)
        {
            Debug.Log("test");

            if (MyImage.sprite == Image_1)
            {
                SetImageTwo();
            }
            else if (MyImage.sprite == Image_2)
            {
                SetImageThree();
            }
            else
            {
                SetImageOne();
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
