using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoneyUI : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private TextMeshProUGUI moneyText;

    private void OnEnable()
    {
        GameEventsManager.instance.moneyEvents.onMoneyChange += MoneyChange;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.moneyEvents.onMoneyChange -= MoneyChange;
    }

    private void MoneyChange(int money)
    {
        moneyText.text = money.ToString();
    }
}
