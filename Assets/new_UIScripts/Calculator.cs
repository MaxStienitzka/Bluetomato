using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public Storage storage;

    public Text skateBoardPrice;

    public Text finalPrice;

    public Text portoPrice;

    public float skateBoardValue;

    public float finalValue;

    public float porto;

    private void Update()
    {
        skateBoardValue = storage.finalBuyingPrice;
        finalValue = porto + skateBoardValue;
        skateBoardPrice.text = "€" + skateBoardValue.ToString();
        portoPrice.text = "€" + porto.ToString();
        finalPrice.text = "€" + finalValue.ToString();
    }
}
