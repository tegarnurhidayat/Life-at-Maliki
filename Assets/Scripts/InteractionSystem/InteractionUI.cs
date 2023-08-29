using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DPUtils.Systems.DateTime;

public class InteractionUI : MonoBehaviour
{
    public GameObject InteractionPanel;
    
    //Click Tidak
    public void ButtonTidakClicked()
    {
        InteractionPanel.SetActive(false);
        PlayerMovement.canMove = true;
    }

    //Click Ketaatan dan Ya
    public void Ketaatan() 
    {
        InteractionPanel.SetActive(true);
        PlayerMovement.canMove = false;
    }
    public void ButtonKetaatanYaClicked()
    {  
        InteractionPanel.SetActive(false);
        PlayerMovement.canMove = true;
    }

    //Click Kepintaran dan Ya
    public void Kepintaran() 
    {
        InteractionPanel.SetActive(true);
        PlayerMovement.canMove = false;
    }
    public void ButtonKepintaranYaClicked()
    {
        InteractionPanel.SetActive(false);
        PlayerMovement.canMove = true;
    }

    //Click Kepintaran dan Ya
    public void Kekuatan()
    {
        InteractionPanel.SetActive(true);
        PlayerMovement.canMove = false;
    }
    public void ButtonKekuatanYaClicked()
    {
        InteractionPanel.SetActive(false);
        PlayerMovement.canMove = true;
    }

    // Work to earn money

    public void Work()
    {
        InteractionPanel.SetActive(true);
        PlayerMovement.canMove = false;
    }

    public void ButtonWorkYaClicked()
    {
        InteractionPanel.SetActive (false);
        PlayerMovement.canMove = true;
    }
}
