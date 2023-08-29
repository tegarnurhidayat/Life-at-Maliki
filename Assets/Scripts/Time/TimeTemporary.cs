using DPUtils.Systems.DateTime;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class TimeTemporary : MonoBehaviour
{
    public TMP_Text clockText;
    public TMP_Text dayText;

    public int minute, hour, date;
    public string day;

    private void Start()
    {
        date = 2;
        hour = 8;
    }

    private void Update()
    {
        TextCallFunction();
        CalculateTime();
        CalculateDay();
    }
    void TextCallFunction()
    {
        clockText.text = string.Format("{0:00}:{1:00}", hour, minute);
        dayText.text = day + ", " + date + " September 2023";
    }

    void CalculateTime()
    {

        if (minute >= 60)
        {
            hour++;
            minute = 0;
        }
        else if (hour >= 24)
        {
            date++;
            hour = 0;
        }
    }

    void CalculateDay()
    {
        if (date == 2)
        {
            day = "Senin";
        }
        else if (date == 3)
        {
            day = "Selasa";
        }
        else if (date == 4)
        {
            day = "Rabu";
        }
        else if (date == 5)
        {
            day = "Kamis";
        }
        else if (date == 6)
        {
            day = "Jumat";
        }
        else if (date == 7)
        {
            day = "Sabtu";
        }
        else if (date == 8)
        {
            day = "Minggu";
        }
    }

    void AlphaEnd()
    {
        if (date == 9)
        {
            // TODO - Buat game gak bisa dimainin ex: pop up ucapan terimakasih udh main game ini + tomboh buat ke main menu
        }
    }

    public void DoingAct()
    {
        hour += 2;
    }
}
