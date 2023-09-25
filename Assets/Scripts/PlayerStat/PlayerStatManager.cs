using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private int startingKetaatan = 1;
    [SerializeField] private int startingExpKetaatan = 0;
    [SerializeField] private int startingKepintaran = 1;
    [SerializeField] private int startingExpKepintaran = 0;
    [SerializeField] private int startingKekuatan = 1;
    [SerializeField] private int startingExpKekuatan = 0;

    private int currentKetaatan;
    private int currentExpKetaatan;
    private int currentKepintaran;
    private int currentExpKepintaran;
    private int currentKekuatan;
    private int currentExpKekuatan;

    private void Awake()
    {
        currentKetaatan = startingKetaatan;
        currentExpKetaatan = startingExpKetaatan;
        currentKepintaran = startingKepintaran;
        currentExpKepintaran = startingExpKepintaran;
        currentKekuatan = startingKekuatan;
        currentExpKekuatan = startingExpKekuatan;
    }

    private void OnEnable()
    {
        GameEventsManager.instance.statEvents.onExperience1Gained += Experience1Gained;
        GameEventsManager.instance.statEvents.onExperience2Gained += Experience2Gained;
        GameEventsManager.instance.statEvents.onExperience3Gained += Experience3Gained;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.statEvents.onExperience1Gained -= Experience1Gained;
        GameEventsManager.instance.statEvents.onExperience2Gained -= Experience2Gained;
        GameEventsManager.instance.statEvents.onExperience3Gained -= Experience3Gained;
    }

    private void Start()
    {
        GameEventsManager.instance.statEvents.PlayerLevel1Change(currentKetaatan);
        GameEventsManager.instance.statEvents.PlayerExperience1Change(currentExpKetaatan);

        GameEventsManager.instance.statEvents.PlayerLevel2Change(currentKepintaran);
        GameEventsManager.instance.statEvents.PlayerExperience2Change(currentExpKepintaran);

        GameEventsManager.instance.statEvents.PlayerLevel3Change(currentKekuatan);
        GameEventsManager.instance.statEvents.PlayerExperience3Change(currentExpKekuatan);
    }

    private void Update()
    {
        Debug.Log(currentExpKetaatan.ToString());
    }

    private void Experience1Gained(int experience1)
    {
        currentExpKetaatan += experience1;
        // check if we're ready to level up
        while (currentExpKetaatan >= GlobalConstant.experienceToLevelUp)
        {
            currentExpKetaatan -= GlobalConstant.experienceToLevelUp;
            currentKetaatan++;
            GameEventsManager.instance.statEvents.PlayerLevel1Change(currentKetaatan);
        }
        GameEventsManager.instance.statEvents.PlayerExperience1Change(currentExpKetaatan);
    }

    private void Experience2Gained(int experience2)
    {
        currentExpKepintaran += experience2;
        // check if we're ready to level up
        while (currentExpKepintaran >= GlobalConstant.experienceToLevelUp)
        {
            currentExpKepintaran -= GlobalConstant.experienceToLevelUp;
            currentKepintaran++;
            GameEventsManager.instance.statEvents.PlayerLevel2Change(currentKepintaran);
        }
        GameEventsManager.instance.statEvents.PlayerExperience2Change(currentExpKepintaran);
    }

    private void Experience3Gained(int experience3)
    {
        currentExpKekuatan += experience3;
        // check if we're ready to level up
        while (currentExpKekuatan >= GlobalConstant.experienceToLevelUp)
        {
            currentExpKekuatan -= GlobalConstant.experienceToLevelUp;
            currentKekuatan++;
            GameEventsManager.instance.statEvents.PlayerLevel3Change(currentKekuatan);
        }
        GameEventsManager.instance.statEvents.PlayerExperience3Change(currentExpKekuatan);
    }
}
