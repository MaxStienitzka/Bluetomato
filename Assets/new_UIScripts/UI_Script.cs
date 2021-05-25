using System.Drawing;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

public class UI_Script : MonoBehaviour
{
    public GameObject ButtonActivated;

    public GameObject ButtonInactive;

    public GameObject addToCart;

    public GameObject auswahl;

    public GameObject parts;
    public GameObject ImagesSqr;
    public GameObject ImagesHigh;

    public GameObject skateboardNormal;

    public GameObject skateboardSmall;

    public void SetAuwahlUI()
    {
        if (ButtonActivated.activeSelf)
        {
            ButtonInactive.SetActive(true);
            addToCart.SetActive(true);
            ButtonActivated.SetActive(false);
            auswahl.SetActive(false);
            parts.SetActive(false);
            skateboardSmall.SetActive(false);
            skateboardNormal.SetActive(true);
        }
        else
        {
            ButtonInactive.SetActive(false);
            ButtonActivated.SetActive(true);
            addToCart.SetActive(false);
            auswahl.SetActive(true);
            parts.SetActive(false);
            skateboardNormal.SetActive(false);
            skateboardSmall.SetActive(true);
        }
    }

    public void Parts()
    {
        parts.SetActive(true);
        auswahl.SetActive(false);
        ImagesHigh.SetActive(false);
        ImagesSqr.SetActive(true);
    }

    public void HighParts()
    {
        parts.SetActive(true);
        auswahl.SetActive(false);
        ImagesSqr.SetActive(false);
        ImagesHigh.SetActive(true);
    }
}