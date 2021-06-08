using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class GuideScript : MonoBehaviour
{
    public GameObject auswahl;
    public GameObject guideOne;

    public void GuideOne()
    {
        guideOne.SetActive(true);
        auswahl.SetActive(false);
    }

    public void Reset()
    {
        auswahl.SetActive(true);
        guideOne.SetActive(false);
    }
}