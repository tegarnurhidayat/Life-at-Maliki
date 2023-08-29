using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour, IDataPersistence
{
    public TMP_Text stat1Text;
    public TMP_Text stat2Text;
    public TMP_Text stat3Text;

    public StatBar statBar;

    public int stat1 = 0;
    public int stat2 = 0;
    public int stat3 = 0;

    public int level1Add = 1;

    public void LoadData(GameData data)
    {
        this.stat1 = data.stat1;
        this.stat2 = data.stat2;
        this.stat3 = data.stat3;
    }

    public void SaveData(ref GameData data)
    {
        data.stat1 = this.stat1;
        data.stat2 = this.stat2;
        data.stat3 = this.stat3;
    }

    private void Update()
    {
        StatsText();
    }

    public void AddStat1()
    {
        stat1 += level1Add;
    }

    public void AddStat2()
    {
        stat2 += level1Add;
    }

    public void AddStat3()
    {
        stat3 += level1Add;
    }

    public void StatsText()
    {
        stat1Text.text = stat1 + "/10";
        statBar.setStat1(stat1);

        stat2Text.text = stat2 + "/10";
        statBar.setStat2(stat2);

        stat3Text.text = stat3 + "/10";
        statBar.setStat3(stat3);
    }
}
