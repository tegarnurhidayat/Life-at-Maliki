using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemsQuestStep : QuestStep
{
    private int itemsCollected = 0;
    private int itemsToComplete = 5;

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void ItemCollected()
    {
        if (itemsCollected < itemsToComplete)
        {
            itemsCollected++;
        }

        if (itemsCollected >= itemsToComplete)
        {
            FinishQuestStep();
        }
    }
}
