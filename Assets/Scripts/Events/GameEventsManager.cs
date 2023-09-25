using System;
using UnityEngine;

public class GameEventsManager : MonoBehaviour
{
    public static GameEventsManager instance { get; private set; }

    public StatEvents statEvents;
    public ItemEvents itemEvents;
    public MiscEvents miscEvents;
    public QuestEvents questEvents;
    public MoneyEvents moneyEvents;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Game Events Manager in the scene.");
        }
        instance = this;

        // initialize all events
        statEvents = new StatEvents();
        itemEvents = new ItemEvents();
        miscEvents = new MiscEvents();
        questEvents = new QuestEvents();
        moneyEvents = new MoneyEvents();
    }
}
