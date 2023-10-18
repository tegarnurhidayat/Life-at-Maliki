using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    // Stats Values
    public static int stat1 = 0;
    public static int stat2 = 0;

    // Display
    public TMP_Text stat1Text;
    public TMP_Text stat2Text;

    void Update()
    {
        StatsText();
    }

    public static void addStat1(int plusStat1)
    {
        stat1 += plusStat1;
    }

    public static void addStat2(int plusStat2)
    {
        stat2 += plusStat2;
    }

    public void StatsText()
    {
        stat1Text.text = "Stat1 : " + stat1;
        stat2Text.text = "Stat2 : " + stat2;
    }
}
