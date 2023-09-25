using DPUtils.Systems.DateTime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuestPopupUI : MonoBehaviour
{
    [SerializeField] private GameObject popUpStart;
    [SerializeField] private GameObject popUpFinish;

    //[Header("Ink JSON")]
    //[SerializeField] private TextAsset inkJson;

    public static bool dialogueStarts;

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void Awake()
    {
        popUpStart.SetActive(false);
        popUpFinish.SetActive(false);
    }

    //public void DialogueInteraction()
    //{
    //    dialogueStarts = true;
    //    DialogueManager.GetInstance().EnterDialogueMode(inkJson);
    //    TimeSystem.CalculateTimeBool = false;
    //    TimeManager.CalculateTimeBool = false;
    //    PlayerMovement.canMove = false;
    //}

    //public void OpenConfirmation()
    //{
    //    popUpConfirmation.SetActive(true);
    //}

    public void ButtonCancel()
    {
        popUpStart.SetActive(false);
        popUpFinish.SetActive(false);
    }

}
