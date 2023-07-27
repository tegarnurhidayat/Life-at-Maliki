using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeSystem : MonoBehaviour
{
    private const int TIMESCALE = 1800; // Ganti 60 lagi nanti

    public static bool CalculateTimeBool;
    public TMP_Text clockText;
    public TMP_Text dayText;
    public TMP_Text monthText;
    public TMP_Text yearText;

    public static double minute, hour, day, month, year, second;

    // Move Scene Sleep
    public string sceneToSleep;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        CalculateTimeBool = true;
        month = 3;
        day = 26;
        year = 2023;
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
        dayText.text = "Day: " + day;
        clockText.text = string.Format("Time: "+ "{0:00}:{1:00}", hour, minute);
        monthText.text = "Month: " + month;
        yearText.text = "Year: " + year;
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
        second += Time.deltaTime * TIMESCALE;

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

    void TimeToSleep()
    {
        if(hour == 1)
        {
            SceneManager.LoadScene(sceneToSleep);
        }
    }

}
