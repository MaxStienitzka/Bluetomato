using UnityEngine;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour
{
    public GameObject homescreen;

    public GameObject customizeScreen;

    public GameObject mapScreen;

    public GameObject buyingScreen;

    public GameObject guideScreen;

    public Image homeButton;

    public Sprite homeOn;

    public Sprite homeOff;

    public Image customizeButton;

    public Sprite customizeOn;

    public Sprite customizeOff;

    public Image mapButton;

    public Sprite mapOn;

    public Sprite mapOff;

    public Image guideButton;

    public Sprite guideOn;

    public Sprite guideOff;

    public Sprite buyOn;

    void Start()
    {
        Homescreen();
    }

    public void Homescreen()
    {
        homescreen.SetActive(true);
        customizeScreen.SetActive(false);
        mapScreen.SetActive(false);
        buyingScreen.SetActive(false);
        guideScreen.SetActive(false);
        homeButton.sprite = homeOn;
        customizeButton.sprite = customizeOff;
        guideButton.sprite = guideOff;
        mapButton.sprite = mapOff;
    }

    public void Customizer()
    {
        homescreen.SetActive(false);
        customizeScreen.SetActive(true);
        mapScreen.SetActive(false);
        buyingScreen.SetActive(false);
        guideScreen.SetActive(false);
        homeButton.sprite = homeOff;
        customizeButton.sprite = customizeOn;
        guideButton.sprite = guideOff;
        mapButton.sprite = mapOff;
    }

    public void Map()
    {
        homescreen.SetActive(false);
        customizeScreen.SetActive(false);
        mapScreen.SetActive(true);
        buyingScreen.SetActive(false);
        guideScreen.SetActive(false);
        homeButton.sprite = homeOff;
        customizeButton.sprite = customizeOff;
        guideButton.sprite = guideOff;
        mapButton.sprite = mapOn;
    }

    public void Buying()
    {
        homescreen.SetActive(false);
        customizeScreen.SetActive(false);
        mapScreen.SetActive(false);
        buyingScreen.SetActive(true);
        guideScreen.SetActive(false);
        homeButton.sprite = homeOff;
        customizeButton.sprite = buyOn;
        guideButton.sprite = guideOff;
        mapButton.sprite = mapOff;
    }

    public void Guide()
    {
        homescreen.SetActive(false);
        customizeScreen.SetActive(false);
        mapScreen.SetActive(false);
        buyingScreen.SetActive(false);
        guideScreen.SetActive(true);
        homeButton.sprite = homeOff;
        customizeButton.sprite = customizeOff;
        guideButton.sprite = guideOn;
        mapButton.sprite = mapOff;
    }
}
