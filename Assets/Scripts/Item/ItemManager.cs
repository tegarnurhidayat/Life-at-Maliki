using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private int startingItem = 1;
    public int currentItem { get; private set; }

    private void Awake()
    {
        currentItem = startingItem;
    }

    private void OnEnable()
    {
        GameEventsManager.instance.itemEvents.onItemGained += ItemGained;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.itemEvents.onItemGained -= ItemGained;
    }

    private void Start()
    {
        GameEventsManager.instance.itemEvents.ItemChange(currentItem);
    }

    private void ItemGained(int item)
    {
        currentItem += item;
        GameEventsManager.instance.itemEvents.ItemChange(currentItem);
    }
}
