using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DPUtils.Systems.DateTime;

public class InteractionUI : MonoBehaviour
{
    public GameObject InteractionPanel;
    
    public TMP_Text statTextKaca;
    public TMP_Text statTextBarbel;

    //Click Tidak
    public void ButtonTidakClicked()
    {
        InteractionPanel.SetActive(false);
        TimeSystem.CalculateTimeBool = true;
        TimeManager.CalculateTimeBool = true;
        PlayerMovement.canMove = true;
    }


    //Click Mirror dan Ya
    public void Mirror() 
    {
        InteractionPanel.SetActive(true);
        statTextKaca.text = "Kemampuan : +1, 2 jam";
        TimeSystem.CalculateTimeBool = false;
        TimeManager.CalculateTimeBool = false;
        PlayerMovement.canMove = false;
    }
    public void ButtonMirrorYaClicked()
    {
        PlayerEnergy.startAct = true;
        PlayerStats.addStat1(1);
        InteractionPanel.SetActive(false);
        TimeSystem.hour += 2;
        TimeSystem.CalculateTimeBool = true;
        TimeManager.CalculateTimeBool = true;
        PlayerMovement.canMove = true;
    }


    //Click Barbel dan Ya
    public void Barbel() 
    {
        InteractionPanel.SetActive(true);
        statTextBarbel.text = "Kekuatan : +1, 3 jam";
        TimeSystem.CalculateTimeBool = false;
        TimeManager.CalculateTimeBool = false;
        PlayerMovement.canMove = false;
    }
    public void ButtonBarbelYaClicked()
    {
        PlayerEnergy.startAct = true;
        PlayerStats.addStat2(1);
        InteractionPanel.SetActive(false);
        TimeSystem.hour += 3;
        TimeSystem.CalculateTimeBool = true;
        TimeManager.CalculateTimeBool = true;
        PlayerMovement.canMove = true;
    }

    // Work to earn money

    public void Work()
    {
        InteractionPanel.SetActive(true);
        TimeSystem.CalculateTimeBool = false;
        TimeManager.CalculateTimeBool = false;
        PlayerMovement.canMove = false;
    }

    public void ButtonWorkYaClicked()
    {
        PlayerEnergy.startAct = true;
        InteractionPanel.SetActive (false);
        TimeSystem.hour += 2;
        TimeSystem.CalculateTimeBool = true;
        TimeManager.CalculateTimeBool = true;
        PlayerMovement.canMove = true;
        // Money
        PlayerMoney.addMoney(50000);
    }
}
