using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    [Header("Menu Button")]

    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueButton;

    private void Start()
    {
        if(!DataPersistenceManager.instance.HasGameData())
        {
            continueButton.interactable = false;
        }
    }
    public void NewGame()
    {
        DisableMenuButton();
        DataPersistenceManager.instance.NewGame();
        SceneManager.LoadSceneAsync("PlayerSelection");
    }

    public void Continue()
    {
        DisableMenuButton();
        SceneManager.LoadSceneAsync("Gameplay");
    }

    private void DisableMenuButton()
    {
        newGameButton.interactable = false;
        continueButton.interactable = false;
    }
}
