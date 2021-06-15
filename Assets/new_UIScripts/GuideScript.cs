using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class GuideScript : MonoBehaviour
{
    public GameObject auswahl;
    public GameObject guideOne;
    public GameObject guideTwo;
    public GameObject guideThree;
    public GameObject guideFour;
    public GameObject guideFive;
    public GameObject guideSix;

    public void GuideOne()
    {
        guideOne.SetActive(true);
        auswahl.SetActive(false);
    }

    public void GuideTwo()
    {
        guideTwo.SetActive(true);
        auswahl.SetActive(false);
    }

    public void GuideThree()
    {
        guideThree.SetActive(true);
        auswahl.SetActive(false);
    }

    public void GuideFour()
    {
        guideFour.SetActive(true);
        auswahl.SetActive(false);
    }

    public void GuideFive()
    {
        guideFive.SetActive(true);
        auswahl.SetActive(false);
    }

    public void GuideSix()
    {
        guideSix.SetActive(true);
        auswahl.SetActive(false);
    }

    public void Reset()
    {
        auswahl.SetActive(true);
        guideOne.SetActive(false);
        guideTwo.SetActive(false);
        guideThree.SetActive(false);
        guideThree.SetActive(false);
        guideFour.SetActive(false);
        guideFive.SetActive(false);
        guideSix.SetActive(false);
    }
}