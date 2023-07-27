using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnergyBar : MonoBehaviour
{

    public Slider slider;

    public TMP_Text EnergyText;

    public void setMaxEnergy(int energy)
    {
        slider.maxValue = energy;
        slider.value = energy;
        EnergyText.text = energy + "/100";
    }

    public void setEnergy(int energy)
    {
        slider.value = energy;
        EnergyText.text = energy + "/100";
    }

}
