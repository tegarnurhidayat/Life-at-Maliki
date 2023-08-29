using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class LoadCharacter : MonoBehaviour, IDataPersistence
{
    public GameObject[] playerPrefabs;
    public GameObject[] cinemachine;

    int selectedCharacter;

    public void LoadData(GameData data)
    {
        this.selectedCharacter = data.selectedCharacter;
    }

    public void SaveData(ref GameData data)
    {
        //data.selectedCharacter = this.selectedCharacter;
    }
    void Start()
    {
        playerPrefabs[selectedCharacter].SetActive(true);
        cinemachine[selectedCharacter].SetActive(true);
    }

   

}
