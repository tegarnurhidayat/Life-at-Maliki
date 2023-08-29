using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatBar : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    public void setStat1(int ketaatanStat)
    {
        slider1.value = ketaatanStat;
    }

    public void setStat2(int kepintaranStat)
    {
        slider2.value = kepintaranStat;
    }

    public void setStat3(int kekuatanStat)
    {
        slider3.value = kekuatanStat;
    }
}
