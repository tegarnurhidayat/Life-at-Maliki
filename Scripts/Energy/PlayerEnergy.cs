using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerEnergy : MonoBehaviour
{

    public static int maxEnergy = 100;
    public static int currentEnergy;

    public EnergyBar energyBar;

    public static bool startAct;

    // Start is called before the first frame update
    void Start()
    {
        startAct = false;
        currentEnergy = maxEnergy;
        energyBar.setMaxEnergy(maxEnergy);
    }

    // Update is called once per frame
    void Update()
    {
        if(startAct) 
        {
            minEnergy(5);
        }
    }

    public void minEnergy(int capek)
    {
        currentEnergy -= capek;

        energyBar.setEnergy(currentEnergy);
        startAct = false;
    }

    
}
