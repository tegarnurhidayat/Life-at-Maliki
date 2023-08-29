using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int money, energy, stat1, stat2, stat3, selectedCharacter;

    public Vector3 playerPosition;

    public GameData()
    {
        this.money = 0;
        this.energy = 0;
        this.stat1 = 0;
        this.stat2 = 0;
        this.stat3 = 0;
        this.selectedCharacter = 0;
        playerPosition = Vector3.zero;
    }
}
