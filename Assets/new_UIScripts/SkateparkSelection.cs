using System.ComponentModel;
using System.Net.Cache;
using UnityEngine;

public class SkateparkSelection : MonoBehaviour
{
    public GameObject map;

    public GameObject schwarzgasse;

    public GameObject cage;

    public GameObject hallein;

    public GameObject skateboard;

    public void Schwarzgasse()
    {
        map.SetActive(false);
        schwarzgasse.SetActive(true);
        skateboard.SetActive(false);
    }

    public void Cage()
    {
        map.SetActive(false);
        cage.SetActive(true);
        skateboard.SetActive(false);
    }

    public void Hallein()
    {
        map.SetActive(false);
        hallein.SetActive(true);
        skateboard.SetActive(false);
    }

    public void Deactivate()
    {
        map.SetActive(true);
        hallein.SetActive(false);
        cage.SetActive(false);
        schwarzgasse.SetActive(false);
    }
}