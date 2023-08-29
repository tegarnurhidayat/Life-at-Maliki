using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour, IDataPersistence
{
    public int money = 0;
    public int workMoney = 15000;

    public TMP_Text moneyText;

    void Update()
    {
        MoneyText();
    }

    public void addMoney()
    {
        money += workMoney;
    }

    public void MoneyText()
    {
        moneyText.text = money.ToString();
    }

    public void LoadData(GameData data)
    {
        this.money = data.money;
    }

    public void SaveData(ref GameData data)
    {
        data.money = this.money;
    }
}
