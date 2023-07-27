using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject button_A;

    // Entering Trigger with Interactable will show A button
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            button_A.SetActive(true);
        }
        
    }

    // Exiting Trigger with Interactable will hide A button
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        { 
            button_A.SetActive(false);
        }
        
    }
}
