using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeSystem : MonoBehaviour
{
    private const int TIMESCALE = 60; // Ganti 60 lagi nanti

    public static bool CalculateTimeBool;
    public TMP_Text clockText;
    public TMP_Text hariText;
    public TMP_Text dayText;
    public TMP_Text monthText;
    public TMP_Text yearText;

    public double minute, hour, day, month, year, second;
    public string hari, bulan;

    // Move Scene Sleep
    public string sceneToSleep;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        CalculateTimeBool = true;
        month = 8;
        hari = "senin";
        day = 1;
        year = 2024;
        hour = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();
        TimeToSleep();

        if (CalculateTimeBool == false)
        {
            Time.timeScale = 0;
        } 
        else
        {
            Time.timeScale = 1;
        }
    }

    void TextCallFunction()
    {
        dayText.text = day.ToString();
        clockText.text = string.Format("{0:00}:{1:00}", hour, minute);
        monthText.text = month.ToString();
        yearText.text = year.ToString();
    }

    void CalculateMonth()
    {
        if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if(day >= 32)
            {
                month++;
                day=1;
                TextCallFunction();
            }
        }

        if(month == 4 || month == 6 || month == 9 || month == 11)
        {
            if(day >= 31)
            {
                month++;
                day=1;
                TextCallFunction();
            }
        }

        if(month == 2)
        {
            month++;
            day=1;
            TextCallFunction();
        }
    }

    void CalculateTime()
    {
        //second += Time.deltaTime * TIMESCALE;

        if(second>=60)
        {
            minute++;
            second = 0;
            TextCallFunction();
        } 
        else if(minute>=60)
        {
            hour++;
            minute=0;
            TextCallFunction();
        }
        else if(hour>=24)
        {
            day++;
            hour=0;
        }
        else if(day>=28)
        {
            CalculateMonth();
        }
        else if(month>12)
        {
            month = 1;
            year++;
            TextCallFunction();
        }
    }

    void CalculateHari()
    {
        if(month == 8 && day == 1 || day == 8 || day == 15 || day == 22 || day == 29)
        {
            hari = "Kamis";
        }
        else if(month == 8 && day == 2 || day == 9 || day == 16 || day == 23 || day == 30)
        {
            hari = "Jumat";
        }
        else if (month == 8 && day == 3 || day == 10 || day == 17 || day == 24 || day == 31)
        {
            hari = "Sabtu";
        }
        else if (month == 8 && day == 4 || day == 11 || day == 18 || day == 25)
        {
            hari = "Minggu";
        }
        else if (month == 8 && day == 5 || day == 12 || day == 19 || day == 26)
        {
            hari = "Senin";
        }
        else if (month == 8 && day == 6 || day == 13 || day == 20 || day == 27)
        {
            hari = "Selasa";
        }
        else if (month == 8 && day == 7 || day == 14 || day == 21 || day == 28)
        {
            hari = "Rabu";
        }
    }

    void TimeToSleep()
    {
        if(hour == 1)
        {
            SceneManager.LoadScene(sceneToSleep);
        }
    }

}
