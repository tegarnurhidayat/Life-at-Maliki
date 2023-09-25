using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatUI : MonoBehaviour
{
    [Header("Stat Ketaatan")]
    [SerializeField] private Slider xpSlider1;
    [SerializeField] private TextMeshProUGUI xpText1;
    [SerializeField] private TextMeshProUGUI levelText1;

    [Header("Stat Kepintaran")]
    [SerializeField] private Slider xpSlider2;
    [SerializeField] private TextMeshProUGUI xpText2;
    [SerializeField] private TextMeshProUGUI levelText2;

    [Header("Stat Kekuatan")]
    [SerializeField] private Slider xpSlider3;
    [SerializeField] private TextMeshProUGUI xpText3;
    [SerializeField] private TextMeshProUGUI levelText3;

    private void OnEnable()
    {
        GameEventsManager.instance.statEvents.onPlayerExperience1Change += PlayerExperience1Change;
        GameEventsManager.instance.statEvents.onPlayerLevel1Change += PlayerLevel1Change;
        GameEventsManager.instance.statEvents.onPlayerExperience2Change += PlayerExperience2Change;
        GameEventsManager.instance.statEvents.onPlayerLevel2Change += PlayerLevel2Change;
        GameEventsManager.instance.statEvents.onPlayerExperience3Change += PlayerExperience3Change;
        GameEventsManager.instance.statEvents.onPlayerLevel3Change += PlayerLevel3Change;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.statEvents.onPlayerExperience1Change -= PlayerExperience1Change;
        GameEventsManager.instance.statEvents.onPlayerLevel1Change -= PlayerLevel1Change;
        GameEventsManager.instance.statEvents.onPlayerExperience2Change -= PlayerExperience2Change;
        GameEventsManager.instance.statEvents.onPlayerLevel2Change -= PlayerLevel2Change;
        GameEventsManager.instance.statEvents.onPlayerExperience3Change -= PlayerExperience3Change;
        GameEventsManager.instance.statEvents.onPlayerLevel3Change -= PlayerLevel3Change;
    }

    private void PlayerExperience1Change(int experience1)
    {
        xpSlider1.value = (float)experience1;
        xpText1.text = experience1 + " / " + GlobalConstant.experienceToLevelUp;
    }

    private void PlayerLevel1Change(int level1)
    {
        levelText1.text = "Level " + level1;
    }

    private void PlayerExperience2Change(int experience2)
    {
        xpSlider2.value = (float)experience2;
        xpText2.text = experience2 + " / " + GlobalConstant.experienceToLevelUp;
    }

    private void PlayerLevel2Change(int level2)
    {
        levelText2.text = "Level " + level2;
    }

    private void PlayerExperience3Change(int experience3)
    {
        xpSlider3.value = (float)experience3;
        xpText3.text = experience3 + " / " + GlobalConstant.experienceToLevelUp;
    }

    private void PlayerLevel3Change(int level3)
    {
        levelText3.text = "Level " + level3;
    }

    
}
