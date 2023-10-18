using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    public static int money = 0;

    public TMP_Text moneyText;

    void Update()
    {
        MoneyText();
    }

    public static void addMoney(int plusMoney)
    {
        money += plusMoney;
    }

    public void MoneyText()
    {
        moneyText.text = money.ToString();
    }
}
