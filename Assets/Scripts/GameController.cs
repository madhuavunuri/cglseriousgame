using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static string diary_address = "Diary_address";
    public static string diary_application = "Diary_application";
    public static string diary_course = "Diary_course";
    public static string diary_deadline = "Diary_deadline";

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("LoadGameFirstTime",0) == 0)
        {
            //Set first values for the game
            PlayerPrefs.SetInt("LoadGameFirstTime", 1);

            //Reset all Information literacy skills for first time loading game
            PlayerPrefs.SetInt("Save" + InfoSkillType.Analyser.ToString(), 0);
            PlayerPrefs.SetInt("Save" + InfoSkillType.Communicator.ToString(), 0);
            PlayerPrefs.SetInt("Save" + InfoSkillType.DecisionMaker.ToString(), 0);
            PlayerPrefs.SetInt("Save" + InfoSkillType.Discoverer.ToString(), 0);

            //Save Day
            PlayerPrefs.SetInt("Save" + "DayValue", 1);

            //Diary Slots Data
            PlayerPrefs.SetString(diary_address, "");
            PlayerPrefs.SetString(diary_application, "");
            PlayerPrefs.SetString(diary_course, "");
            PlayerPrefs.SetString(diary_deadline, "");

        }
    }

}
