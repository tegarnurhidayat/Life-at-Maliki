using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public GameObject[] cinemachine;
  
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        playerPrefabs[selectedCharacter].SetActive(true);
        cinemachine[selectedCharacter].SetActive(true);
    }

}
