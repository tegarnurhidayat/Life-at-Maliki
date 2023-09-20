using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhoto : MonoBehaviour, IDataPersistence
{
    public GameObject[] playerProfile;
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
        playerProfile[selectedCharacter].SetActive(true);
    }


}
