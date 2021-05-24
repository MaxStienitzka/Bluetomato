using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class GuideScript : MonoBehaviour
{
public GameObject auswahl;
public GameObject info;
public Image image;
public Text descr;
public List<string> guideInfo;
public List<Sprite> guideImage;

public void close(){
    auswahl.SetActive(false);
}
public void GuideOne(){
    descr.text = guideInfo[0];
    image.sprite = guideImage[0];
}
}
