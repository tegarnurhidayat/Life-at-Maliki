using DPUtils.Systems.DateTime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Dialogue Cue")]
    [SerializeField] private GameObject dialogueButtonCue;
    [SerializeField] private Boolean isCutscene; //Apakah ini dialogue cutscene?
    [SerializeField] private int CutsceneCount; //Variabel agar cutscene tidak tertrigger lagi

    private bool playerInRange;
    public static bool dialogueStarts;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJson;

    private void Awake()
    {
        playerInRange = false;
        dialogueButtonCue.SetActive(false);
    }

    private void Update()
    {
        if (!isCutscene)
        {
            if (playerInRange && !dialogueStarts)
            {
                dialogueButtonCue.SetActive(true);
            }
            else if (playerInRange && dialogueStarts)
            {
                dialogueButtonCue.SetActive(false);
            }
            else
            {
                dialogueButtonCue.SetActive(false);
            }
        } else if (isCutscene && CutsceneCount == 0) 
        {
            if (playerInRange)
            {
                DialogueInteraction();
                CutsceneCount += 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }


    public void DialogueInteraction()
    {
        //Debug.Log(inkJson.text);
        dialogueStarts = true;
        DialogueManager.GetInstance().EnterDialogueMode(inkJson);
        TimeSystem.CalculateTimeBool = false;
        TimeManager.CalculateTimeBool = false;
        PlayerMovement.canMove = false;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            dialogueStarts = false;
            playerInRange = false;
        }
    }
}
