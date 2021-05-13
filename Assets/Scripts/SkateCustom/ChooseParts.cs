using UnityEngine;
using UnityEngine.UI;

public class ChooseParts : MonoBehaviour
{
    public GameObject Liste;
    public GameObject DeckButton;
    public GameObject AchsenButton;
    public GameObject GriptapeButton;
    public GameObject RollersButton;
    public GameObject HardwareButton;
    public GameObject Skateboard;
    public Vector3 NewSkateboardcordinates;
    public Vector3 OldSkateboardcordinates;
    public void DropDownMenu()
    {
        if (!Liste.activeSelf)
        {
            Liste.SetActive(true);
            Skateboard.transform.position = NewSkateboardcordinates;
        }
        else
        {
            Liste.SetActive(false);
            Skateboard.transform.position = OldSkateboardcordinates;

        }

    }

    public void switchToDeckFuction()
    {

        if (!DeckButton.activeSelf)
        {
            DeckButton.SetActive(true);
            AchsenButton.SetActive(false);
            GriptapeButton.SetActive(false);
            RollersButton.SetActive(false);
            HardwareButton.SetActive(false);
            Liste.SetActive(false);
            Skateboard.transform.position = OldSkateboardcordinates;
        }
    }
    public void switchToAchsenFunction()
    {
        if (!AchsenButton.activeSelf)
        {
            DeckButton.SetActive(false);
            AchsenButton.SetActive(true);
            GriptapeButton.SetActive(false);
            RollersButton.SetActive(false);
            HardwareButton.SetActive(false);
            Liste.SetActive(false);
            Skateboard.transform.position = OldSkateboardcordinates;
        }
    }

    public void switchToGriptapeFunction(){
    if (!GriptapeButton.activeSelf)
        {
            DeckButton.SetActive(false);
            AchsenButton.SetActive(false);
            GriptapeButton.SetActive(true);
            RollersButton.SetActive(false);
            HardwareButton.SetActive(false);
            Liste.SetActive(false);
            Skateboard.transform.position = OldSkateboardcordinates;
        }

}
    public void switchToRollersButtonFunction(){
    if (!RollersButton.activeSelf)
        {
            DeckButton.SetActive(false);
            AchsenButton.SetActive(false);
            GriptapeButton.SetActive(false);
            RollersButton.SetActive(true);
            HardwareButton.SetActive(false);
            Liste.SetActive(false);
            Skateboard.transform.position = OldSkateboardcordinates;
        }

}
 public void switchToHardwareButtonFunction(){
    if (!HardwareButton.activeSelf)
        {
            DeckButton.SetActive(false);
            AchsenButton.SetActive(false);
            GriptapeButton.SetActive(false);
            RollersButton.SetActive(false);
            HardwareButton.SetActive(true);
            Liste.SetActive(false);
            Skateboard.transform.position = OldSkateboardcordinates;
        }


}
}
