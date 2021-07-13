using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    
    TimeSpan timeCounter;
    DateTime lastChecked;
    int day_Value = 0;

    public Text txtTime;
    public float updateFrequency = 0.1f;
    public int secPerDay = 15;
  
    void Start()
    {

        day_Value = PlayerPrefs.GetInt("Save" + "DayValue", 1);

        string strVal = PlayerPrefs.GetString("TimeRun", "");
        long ticks = 0;

        long.TryParse(strVal, out ticks);

        timeCounter = new TimeSpan(ticks);

        lastChecked = DateTime.Now;

        StartCoroutine(CalcAndDisplay());
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("TimeRun", timeCounter.Ticks.ToString());
        PlayerPrefs.Save();
    }

    IEnumerator CalcAndDisplay()
    {
        bool bRun = true;

        while (bRun)
        {
            DateTime now = DateTime.Now;

            timeCounter += now - lastChecked;

            lastChecked = now;

           
            //Increase Day based on timer and Reset Timer 
            if (timeCounter.Seconds >= secPerDay)
            {
                day_Value++;

                PlayerPrefs.SetString("TimeRun", "");
                long ticks = 0;

                long.TryParse(PlayerPrefs.GetString("TimeRun", ""), out ticks);

                timeCounter = new TimeSpan(ticks);

                lastChecked = DateTime.Now;
            }


            txtTime.text = "Day " + day_Value+"\n"+
               string.Format("{0:D2}:{1:D2}:{2:D2}", timeCounter.Hours, timeCounter.Minutes, timeCounter.Seconds);

            yield return new WaitForSeconds(updateFrequency);
        }
    }
}
