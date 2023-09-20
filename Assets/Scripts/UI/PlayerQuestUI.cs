using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerQuestUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI questTitle;
    [SerializeField] private TextMeshProUGUI questProgres;

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onStartQuest += CurrentQuest;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onStartQuest -= CurrentQuest;
    }

    private void CurrentQuest(string id)
    {
        questTitle.text = id;
    }
}
