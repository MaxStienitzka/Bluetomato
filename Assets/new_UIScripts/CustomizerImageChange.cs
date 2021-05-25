using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizerImageChange : MonoBehaviour
{
    public List<Image> VertButtons;
    public List<Image> Buttons;
    public List<Sprite> Decks;
    public List<Sprite> Grip;
    public List<Sprite> Rollers;
    public List<Sprite> Bearings;

    public void DeckImages()
    {
        VertButtons[0].sprite = Decks[0];
        VertButtons[1].sprite = Decks[1];
        VertButtons[2].sprite = Decks[2];
        VertButtons[3].sprite = Decks[3];
        VertButtons[4].sprite = Decks[4];
        VertButtons[5].sprite = Decks[5];
        VertButtons[6].sprite = Decks[6];
    }

    public void GripImages()
    {
        VertButtons[0].sprite = Grip[0];
        VertButtons[1].sprite = Grip[1];
        VertButtons[2].sprite = Grip[2];
        VertButtons[3].sprite = Grip[3];
        VertButtons[4].sprite = Grip[4];
        VertButtons[5].sprite = Grip[5];
        VertButtons[6].sprite = Grip[6];
    }

    public void RolersImages()
    {
        Buttons[0].sprite = Rollers[0];
        Buttons[1].sprite = Rollers[1];
        Buttons[2].sprite = Rollers[2];
        Buttons[3].sprite = Rollers[3];
        Buttons[4].sprite = Rollers[4];
        Buttons[5].sprite = Rollers[5];
        Buttons[6].sprite = Rollers[6];
    }

    public void BearingsImages()
    {
        Buttons[0].sprite = Bearings[0];
        Buttons[1].sprite = Bearings[1];
        Buttons[2].sprite = Bearings[2];
        Buttons[3].sprite = Bearings[3];
        Buttons[4].sprite = Bearings[4];
        Buttons[5].sprite = Bearings[5];
        Buttons[6].sprite = Bearings[6];
    }
}