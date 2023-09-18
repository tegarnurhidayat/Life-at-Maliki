using System;
using UnityEngine;

public class GameEventsManager : MonoBehaviour
{
    public static GameEventsManager instance { get; private set; }

    public InputEvents inputEvents;
    public StatEvents statEvents;
    public ItemEvents itemEvents;
    public MiscEvents miscEvents;
    public QuestEvents questEvents;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Game Events Manager in the scene.");
        }
        instance = this;

        // initialize all events
        inputEvents = new InputEvents();
        statEvents = new StatEvents();
        itemEvents = new ItemEvents();
        miscEvents = new MiscEvents();
        questEvents = new QuestEvents();
    }
}
