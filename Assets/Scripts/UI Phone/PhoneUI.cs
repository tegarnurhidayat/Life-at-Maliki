using DPUtils.Systems.DateTime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneUI : MonoBehaviour
{
    public GameObject UIPhone;

    public GameObject page2;
    public GameObject page3;

    public bool page2IsOn = false;
    public bool page3IsOn = false;

    private void Start()
    {
        UIPhone.SetActive(false);
        page2.SetActive(false);
        page3.SetActive(false);
    }

    public void PhoneButtonClicked()
    {
        UIPhone.SetActive(true);
        TimeManager.CalculateTimeBool = false;
        AudioManager.instance.PlaySFX("Popup Phone");
    }

    public void HomeButtonClicked()
    {
        page2.SetActive(false);
        page3.SetActive(false);
        UIPhone.SetActive(false);
        TimeManager.CalculateTimeBool = true;  
    }

    public void BackButtonClicked()
    {
        if(page2IsOn == true)
        {
            page2.SetActive(false);
        }
        if (page3IsOn == true)
        {
            page3.SetActive(false);
        }
    }

    // Page
    public void ProfileButtonClicked()
    {
        page2.SetActive(true);
        page2IsOn = true;
    }

    public void SettingButtonClicked()
    {
        page3.SetActive(true);
        page3IsOn = true;
    }

    
}
