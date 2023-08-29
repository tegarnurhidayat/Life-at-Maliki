using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerEnergy : MonoBehaviour
{

    public int maxEnergy = 100;
    public int currentEnergy;

    public EnergyBar energyBar;

    public int energyNeeded = 5;

    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.setMaxEnergy(maxEnergy);
    }

    public void minEnergy()
    {
        currentEnergy -= energyNeeded;

        energyBar.setEnergy(currentEnergy);
    }

    
}
