using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static string diary_address = "Diary_address";
    public static string diary_application = "Diary_application";
    public static string diary_course = "Diary_course";
    public static string diary_deadline = "Diary_deadline";

    public static string post_CV = "Save_CV";
    public static string post_LOM = "Save_LOM";
    public static string post_StudyCertificate = "Save_StudyCertificate";


    public static bool isCVCreated = false;
    public static bool isLOMCreated = false;
    public static bool isStudyCerttificatCreated = false;


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
            PlayerPrefs.SetString(diary_address, null);
            PlayerPrefs.SetString(diary_application, null);
            PlayerPrefs.SetString(diary_course, null);
            PlayerPrefs.SetString(diary_deadline, null);

            isCVCreated = false;
            isLOMCreated = false;
            isStudyCerttificatCreated = false;

            PlayerPrefs.SetString(post_CV, null);
            PlayerPrefs.SetString(post_LOM, null);
            PlayerPrefs.SetString(post_StudyCertificate, null);

        }
    }

}
