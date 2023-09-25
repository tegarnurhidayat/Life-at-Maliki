using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class QuestPoint : MonoBehaviour
{
    [SerializeField] private QuestInfoSO questInfoForPoint;
    [SerializeField] private GameObject chatBubble;

    [Header("Config")]
    [SerializeField] private bool startPoint = true;
    [SerializeField] private bool finishPoint = true;

    [Header("UI")]
    [SerializeField] private GameObject popUpStart;
    [SerializeField] private GameObject popUpFinish;

    private bool playerIsNear = false;
    private string questId;
    private QuestState currentQuestState;

    private void Awake()
    {
        questId = questInfoForPoint.id;
        popUpStart.SetActive(false);
        popUpFinish.SetActive(false);
    }

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onQuestStateChange += QuestStateChange;
        //GameEventsManager.instance.inputEvents.onSubmitPressed += SubmitPressed;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onQuestStateChange -= QuestStateChange;
        //GameEventsManager.instance.inputEvents.onSubmitPressed -= SubmitPressed;
    }

    public void SubmitPressed()
    {
        if (!playerIsNear)
        {
            return;
        }

        if (currentQuestState.Equals(QuestState.CAN_START) && startPoint)
        {
            GameEventsManager.instance.questEvents.StartQuest(questId);
        }
        else if (currentQuestState.Equals(QuestState.CAN_FINISH) && finishPoint)
        {
            GameEventsManager.instance.questEvents.FinishQuest(questId);
        }
    }

    public void OpenPopUp()
    {
        if (currentQuestState.Equals(QuestState.CAN_START))
        {
            popUpStart.SetActive(true);
        }
        else if (currentQuestState.Equals(QuestState.CAN_FINISH))
        {
            popUpFinish.SetActive(true);
        }
    }

    private void QuestStateChange(Quest quest)
    {
        if (quest.info.id.Equals(questId))
        {
            currentQuestState = quest.state;
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsNear = true;
            chatBubble.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsNear = false;
            chatBubble.SetActive(false);
        }
    }
}