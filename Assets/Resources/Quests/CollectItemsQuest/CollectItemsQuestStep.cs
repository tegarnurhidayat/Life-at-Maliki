using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemsQuestStep : QuestStep
{
    private int itemsCollected = 0;
    private int itemsToComplete = 5;

    private void OnEnable()
    {
        GameEventsManager.instance.miscEvents.onItemCollected += ItemCollected;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.miscEvents.onItemCollected -= ItemCollected;
    }

    private void ItemCollected()
    {
        if (itemsCollected < itemsToComplete)
        {
            itemsCollected++;
            UpdateState();
        }

        if (itemsCollected >= itemsToComplete)
        {
            FinishQuestStep();
        }
    }

    private void UpdateState()
    {
        string state = itemsCollected.ToString();
        ChangeState(state);
    }

    protected override void SetQuestStepState(string state)
    {
        this.itemsCollected = System.Int32.Parse(state);
        UpdateState();
    }
}
