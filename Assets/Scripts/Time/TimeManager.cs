using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DPUtils.Systems.DateTime
{
    public class TimeManager : MonoBehaviour
    {
        [Header("Tanggal & Waktu")]
        [Range(1, 28)]
        public int dateInMonth;
        [Range(1, 12)]
        public int monthInYear;
        [Range(1, 9999)]
        public int year;
        [Range(0, 24)]
        public int hour;
        [Range(0, 6)]
        public int minutes;

        private DateTime DateTime;

        [Header("Tick Setting")]
        public int TickSecondsIncrease = 10;
        public float TimeBetweenTicks = 1f;
        private float currentTimeBetweenTicks = 0f;

        public static UnityAction<DateTime> OnDateTimeChanged;

        public static bool CalculateTimeBool;

        private void Awake()
        {
            DateTime = new DateTime(dateInMonth, monthInYear, year, hour, minutes * 10);
        }

        private void Start()
        {
            OnDateTimeChanged?.Invoke(DateTime);
            CalculateTimeBool = true;
        }

        private void Update()
        {
            currentTimeBetweenTicks += Time.deltaTime;
            if (currentTimeBetweenTicks >= TimeBetweenTicks)
            {
                currentTimeBetweenTicks = 0f;
                Tick();
            }

            if (CalculateTimeBool == false)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }

        void Tick()
        {
            AdvanceTime();
        }

        void AdvanceTime()
        {
            DateTime.AdvanceMinutes(TickSecondsIncrease);
            OnDateTimeChanged?.Invoke(DateTime);

        }
    }

    [System.Serializable]
    public struct DateTime
    {
        #region Fields
        public Days day;
        public int date;
        public Month month;
        public int year;

        public int hour;
        public int minute;

        #endregion

        #region Properties
        public Days Day => day;
        public int Date => date;
        public Month Month => month;
        public int Hour => hour;
        public int Minutes => Minutes;
        public int Year => year;
        #endregion

        #region Constructors
        public DateTime(int date, int month, int year, int hour, int minute)
        {
            this.day = (Days)(date % 7);
            if (day == 0) day = (Days)7;
            this.date = date;
            this.month = (Month)month;
            this.year = year;

            this.hour = hour;
            this.minute = minute;
        }
        #endregion

        #region Time Advancement

        public void AdvanceMinutes(int SecondsToAdvanceBy)
        {
            if (minute + SecondsToAdvanceBy >= 60)
            {
                minute = (minute + SecondsToAdvanceBy) % 60;
                AdvanceHour();
            }
            else
            {
                minute += SecondsToAdvanceBy;
            }
        }

        private void AdvanceHour()
        {
            if (Hour + 1 >= 24)
            {
                hour = 0;
                AdvanceDay();
            }
            else
            {
                hour++;
            }
        }

        private void AdvanceDay()
        {
            if (day + 1 > (Days)7)
            {
                day = (Days)1;
            }
            else
            {
                day++;
            }
            date++;

            if (date % 29 == 0)
            {
                AdvanceMonth();
                date = 1;
            }
        }

        private void AdvanceMonth()
        {
            if (month + 1 > (Month)12)
            {
                month = (Month)1;
                AdvanceYear();
            }
            else
            {
                month++;
            }
        }

        private void AdvanceYear()
        {
            date = 1;
            year++;
        }

        #endregion

        #region Bool Checks

        public bool IsNight()
        {
            return hour > 18 || hour < 6;
        }

        public bool IsAfternoon()
        {
            return hour > 12 && hour < 18;
        }
        #endregion

        #region String Formatting

        public override string ToString()
        {
            return $"Date: {DateToString()} Month: {month.ToString()} Time: {TimeToString()} ";
        }

        public string DateToString()
        {
            return $"{Day} , {Date} {month.ToString()} {Year.ToString("D4")}";
        }

        public string TimeToString()
        {
            int adjustedHour = 0;

            if (hour == 0)
            {
                adjustedHour = 12;
            }
            else if (hour == 24)
            {
                adjustedHour = 12;
            }
            else if (hour >= 13)
            {
                adjustedHour = hour - 12;
            }
            else
            {
                adjustedHour = hour;
            }

            string AmPm = hour < 12 ? "AM" : "PM";

            return $"{adjustedHour.ToString("D2")}:{minute.ToString("D2")} {AmPm}";
        }
        #endregion
    }

    [System.Serializable]
    public enum Days
    {
        NULL = 0,
        Senin = 1,
        Selasa = 2,
        Rabu = 3,
        Kamis = 4,
        Jumat = 5,
        Sabtu = 6,
        Minggu = 7
    }

    public enum Month
    {
        Jan = 1,
        Feb = 2,
        Mar = 3,
        Apr = 4,
        Mei = 5,
        Jun = 6,
        Jul = 7,
        Agu = 8,
        Sep = 9,
        Okt = 10,
        Nov = 11,
        Des = 12
    }

}