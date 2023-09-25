using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private int startingMoney = 0;

    public int currentMoney { get; private set; }

    private void Awake()
    {
        currentMoney = startingMoney;
    }

    private void OnEnable()
    {
        GameEventsManager.instance.moneyEvents.onMoneyGained += MoneyGained;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.moneyEvents.onMoneyGained -= MoneyGained;
    }

    private void Start()
    {
        GameEventsManager.instance.moneyEvents.MoneyChange(currentMoney);
    }

    private void MoneyGained(int money)
    {
        currentMoney += money;
        GameEventsManager.instance.moneyEvents.MoneyChange(currentMoney);
    }
}
