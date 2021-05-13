using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuyingScript : MonoBehaviour
{
    public Image header;

    public Text headerText;

    public Sprite newHeader;

    public Sprite oldHeader;

    public bool addedToCart;

    public GameObject cart;

    public GameObject buyingScreen;

    public GameObject addedItem;

    public GameObject kasse;

    void Update()
    {
        if (buyingScreen.active)
        {
            header.sprite = newHeader;
            headerText.color = Color.white;
            headerText.text = "Warenkorb";
            cart.SetActive(false);
        }
        else
        {
            header.sprite = oldHeader;
            headerText.color = Color.black;
            headerText.text = "Bluetomato";
            cart.SetActive(true);
        }

        if (addedToCart)
        {
            addedItem.SetActive(true);
        }
        else
        {
            addedItem.SetActive(false);
        }
    }

    public void AddToCart()
    {
        addedToCart = true;
    }

    public void TakeFromCart()
    {
        addedToCart = false;
    }

    public void ZurKasse()
    {
        kasse.SetActive(true);
    }

    public void Zurück()
    {
        kasse.SetActive(false);
        addedToCart = false;
    }
}
