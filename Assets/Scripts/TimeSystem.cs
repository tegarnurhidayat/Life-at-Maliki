using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{
    private const int TIMESCALE = 1800; // Ganti 60 lagi nanti

    public Text clockText;
    public Text dayText;
    public Text monthText;
    public Text yearText;

    public static double minute, hour, day, month, year, second;
    // Start is called before the first frame update
    void Start()
    {
        month = 3;
        day = 26;
        year = 2023;
        hour = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();
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

}
