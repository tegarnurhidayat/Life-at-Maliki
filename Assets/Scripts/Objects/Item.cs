using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int itemGained = 1;

    private void CollectItem()
    {
        GameEventsManager.instance.itemEvents.ItemGained(itemGained);
        GameEventsManager.instance.miscEvents.ItemCollected();
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            CollectItem();
            Destroy(this.gameObject);
        }
    }
}
