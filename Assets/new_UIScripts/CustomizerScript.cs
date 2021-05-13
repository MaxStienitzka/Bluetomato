using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class CustomizerScript : MonoBehaviour
{
    private int i;

    public GameObject skateBoard;

    private int arrayPos;

    public GameObject gripTape;

    public bool gripChoose = false;

    public GameObject deck;

    public bool deckChoose = false;

    public GameObject rollers;

    public bool rollersChoose = false;

    public GameObject achse;

    public bool achseChoose = false;

    public GameObject barrings;

    public bool barringChoose = false;

    public GameObject stoppers;

    public bool stopperChoose = false;

    public List<Material> gripMaterials;

    public List<float> gripPrice;

    public List<Material> deckMaterials;

    public List<float> deckPrice;

    public List<Material> rollersMaterials;

    public List<float> rollersPrice;

    public List<Material> achseMaterials;

    public List<float> achsePrice;

    public List<Material> barringMaterials;

    public List<float> barringsPrice;

    public List<Material> stopperMaterials;

    public List<float> stopppersPrice;

    public Text partPrice;

    public Text finalPrice;

    private float gripValue;

    private float deckValue;

    private float rollersValue;

    private float achseValue;

    private float barringValue;

    private float stopperValue;

    private float finalValue;

    public Storage storage;

    public void ActivateSkateboard()
    {
        skateBoard.SetActive(true);
        Debug.Log(gripMaterials[0]);
        gripTape.GetComponent<Renderer>().material = gripMaterials[0];
        gripValue = gripPrice[0];

        Debug.Log(deckMaterials[0]);
        deck.GetComponent<Renderer>().material = deckMaterials[0];
        deckValue = deckPrice[0];

        Debug.Log(rollersMaterials[0]);
        rollers.GetComponent<Renderer>().material = rollersMaterials[0];
        rollersValue = rollersPrice[0];

        Debug.Log(achseMaterials[0]);
        achse.GetComponent<Renderer>().material = achseMaterials[0];
        achseValue = deckPrice[0];

        Debug.Log(barringMaterials[0]);
        barrings.GetComponent<Renderer>().material = barringMaterials[0];
        barringValue = barringsPrice[0];

        Debug.Log(stopperMaterials[0]);
        stoppers.GetComponent<Renderer>().material = stopperMaterials[0];
        stopperValue = stopppersPrice[0];
    }

    public void Grip()
    {
        gripChoose = true;
        deckChoose = false;
        rollersChoose = false;
        achseChoose = false;
        barringChoose = false;
        stopperChoose = false;
    }

    public void Deck()
    {
        gripChoose = false;
        deckChoose = true;
        rollersChoose = false;
        achseChoose = false;
        barringChoose = false;
        stopperChoose = false;
    }

    public void Rollers()
    {
        gripChoose = false;
        deckChoose = false;
        rollersChoose = true;
        achseChoose = false;
        barringChoose = false;
        stopperChoose = false;
    }

    public void Achse()
    {
        gripChoose = false;
        deckChoose = false;
        rollersChoose = false;
        achseChoose = true;
        barringChoose = false;
        stopperChoose = false;
    }

    public void Barring()
    {
        gripChoose = false;
        deckChoose = false;
        rollersChoose = false;
        achseChoose = false;
        barringChoose = true;
        stopperChoose = false;
    }

    public void Stopper()
    {
        gripChoose = false;
        deckChoose = false;
        rollersChoose = false;
        achseChoose = false;
        barringChoose = false;
        stopperChoose = true;
    }

    void Update()
    {
        if (gripChoose)
        {
            partPrice.text = gripValue.ToString();
        }
        if (deckChoose)
        {
            partPrice.text = deckValue.ToString();
        }
        if (achseChoose)
        {
            partPrice.text = achseValue.ToString();
        }
        if (barringChoose)
        {
            partPrice.text = barringValue.ToString();
        }
        if (stopperChoose)
        {
            partPrice.text = stopperValue.ToString();
        }
        finalValue =
            gripValue + deckValue + achseValue + barringValue + stopperValue;

        storage.finalBuyingPrice = finalValue;
        finalPrice.text = finalValue.ToString();
    }

    public void MaterialOne()
    {
        i = 0;
        if (gripChoose)
        {
            Debug.Log(gripMaterials[i]);
            gripTape.GetComponent<Renderer>().material = gripMaterials[i];
            gripValue = gripPrice[i];
        }
        if (deckChoose)
        {
            Debug.Log(deckMaterials[i]);
            deck.GetComponent<Renderer>().material = deckMaterials[i];
            deckValue = deckPrice[i];
        }
        if (rollersChoose)
        {
            Debug.Log(rollersMaterials[i]);
            rollers.GetComponent<Renderer>().material = rollersMaterials[i];
            rollersValue = rollersPrice[i];
        }
        if (achseChoose)
        {
            Debug.Log(achseMaterials[i]);
            achse.GetComponent<Renderer>().material = achseMaterials[i];
            achseValue = deckPrice[i];
        }
        if (barringChoose)
        {
            Debug.Log(barringMaterials[i]);
            barrings.GetComponent<Renderer>().material = barringMaterials[i];
            barringValue = barringsPrice[i];
        }
        if (stopperChoose)
        {
            Debug.Log(stopperMaterials[i]);
            stoppers.GetComponent<Renderer>().material = stopperMaterials[i];
            stopperValue = stopppersPrice[i];
        }
    }

    public void MaterialTwo()
    {
        i = 1;
        if (gripChoose)
        {
            Debug.Log(gripMaterials[i]);
            gripTape.GetComponent<Renderer>().material = gripMaterials[i];
            gripValue = gripPrice[i];
        }
        if (deckChoose)
        {
            Debug.Log(deckMaterials[i]);
            deck.GetComponent<Renderer>().material = deckMaterials[i];
            deckValue = deckPrice[i];
        }
        if (rollersChoose)
        {
            Debug.Log(rollersMaterials[i]);
            rollers.GetComponent<Renderer>().material = rollersMaterials[i];
            rollersValue = rollersPrice[i];
        }
        if (achseChoose)
        {
            Debug.Log(achseMaterials[i]);
            achse.GetComponent<Renderer>().material = achseMaterials[i];
            achseValue = deckPrice[i];
        }
        if (barringChoose)
        {
            Debug.Log(barringMaterials[i]);
            barrings.GetComponent<Renderer>().material = barringMaterials[i];
            barringValue = barringsPrice[i];
        }
        if (stopperChoose)
        {
            Debug.Log(stopperMaterials[i]);
            stoppers.GetComponent<Renderer>().material = stopperMaterials[i];
            stopperValue = stopppersPrice[i];
        }
    }

    public void MaterialThree()
    {
        i = 2;
        if (gripChoose)
        {
            Debug.Log(gripMaterials[i]);
            gripTape.GetComponent<Renderer>().material = gripMaterials[i];
            gripValue = gripPrice[i];
        }
        if (deckChoose)
        {
            Debug.Log(deckMaterials[i]);
            deck.GetComponent<Renderer>().material = deckMaterials[i];
            deckValue = deckPrice[i];
        }
        if (rollersChoose)
        {
            Debug.Log(rollersMaterials[i]);
            rollers.GetComponent<Renderer>().material = rollersMaterials[i];
            rollersValue = rollersPrice[i];
        }
        if (achseChoose)
        {
            Debug.Log(achseMaterials[i]);
            achse.GetComponent<Renderer>().material = achseMaterials[i];
            achseValue = deckPrice[i];
        }
        if (barringChoose)
        {
            Debug.Log(barringMaterials[i]);
            barrings.GetComponent<Renderer>().material = barringMaterials[i];
            barringValue = barringsPrice[i];
        }
        if (stopperChoose)
        {
            Debug.Log(stopperMaterials[i]);
            stoppers.GetComponent<Renderer>().material = stopperMaterials[i];
            stopperValue = stopppersPrice[i];
        }
    }
    public void MaterialFour()
    {
        i = 3;
        if (gripChoose)
        {
            Debug.Log(gripMaterials[i]);
            gripTape.GetComponent<Renderer>().material = gripMaterials[i];
            gripValue = gripPrice[i];
        }
        if (deckChoose)
        {
            Debug.Log(deckMaterials[i]);
            deck.GetComponent<Renderer>().material = deckMaterials[i];
            deckValue = deckPrice[i];
        }
        if (rollersChoose)
        {
            Debug.Log(rollersMaterials[i]);
            rollers.GetComponent<Renderer>().material = rollersMaterials[i];
            rollersValue = rollersPrice[i];
        }
        if (achseChoose)
        {
            Debug.Log(achseMaterials[i]);
            achse.GetComponent<Renderer>().material = achseMaterials[i];
            achseValue = deckPrice[i];
        }
        if (barringChoose)
        {
            Debug.Log(barringMaterials[i]);
            barrings.GetComponent<Renderer>().material = barringMaterials[i];
            barringValue = barringsPrice[i];
        }
        if (stopperChoose)
        {
            Debug.Log(stopperMaterials[i]);
            stoppers.GetComponent<Renderer>().material = stopperMaterials[i];
            stopperValue = stopppersPrice[i];
        }

    }
    public void MaterialFive()
    {
        i = 4;
        if (gripChoose)
        {
            Debug.Log(gripMaterials[i]);
            gripTape.GetComponent<Renderer>().material = gripMaterials[i];
            gripValue = gripPrice[i];
        }
        if (deckChoose)
        {
            Debug.Log(deckMaterials[i]);
            deck.GetComponent<Renderer>().material = deckMaterials[i];
            deckValue = deckPrice[i];
        }
        if (rollersChoose)
        {
            Debug.Log(rollersMaterials[i]);
            rollers.GetComponent<Renderer>().material = rollersMaterials[i];
            rollersValue = rollersPrice[i];
        }
        if (achseChoose)
        {
            Debug.Log(achseMaterials[i]);
            achse.GetComponent<Renderer>().material = achseMaterials[i];
            achseValue = deckPrice[i];
        }
        if (barringChoose)
        {
            Debug.Log(barringMaterials[i]);
            barrings.GetComponent<Renderer>().material = barringMaterials[i];
            barringValue = barringsPrice[i];
        }
        if (stopperChoose)
        {
            Debug.Log(stopperMaterials[i]);
            stoppers.GetComponent<Renderer>().material = stopperMaterials[i];
            stopperValue = stopppersPrice[i];
        }
    }
    public void MaterialSix()
    {
        i = 5;
        if (gripChoose)
        {
            Debug.Log(gripMaterials[i]);
            gripTape.GetComponent<Renderer>().material = gripMaterials[i];
            gripValue = gripPrice[i];
        }
        if (deckChoose)
        {
            Debug.Log(deckMaterials[i]);
            deck.GetComponent<Renderer>().material = deckMaterials[i];
            deckValue = deckPrice[i];
        }
        if (rollersChoose)
        {
            Debug.Log(rollersMaterials[i]);
            rollers.GetComponent<Renderer>().material = rollersMaterials[i];
            rollersValue = rollersPrice[i];
        }
        if (achseChoose)
        {
            Debug.Log(achseMaterials[i]);
            achse.GetComponent<Renderer>().material = achseMaterials[i];
            achseValue = deckPrice[i];
        }
        if (barringChoose)
        {
            Debug.Log(barringMaterials[i]);
            barrings.GetComponent<Renderer>().material = barringMaterials[i];
            barringValue = barringsPrice[i];
        }
        if (stopperChoose)
        {
            Debug.Log(stopperMaterials[i]);
            stoppers.GetComponent<Renderer>().material = stopperMaterials[i];
            stopperValue = stopppersPrice[i];
        }
    }
}
