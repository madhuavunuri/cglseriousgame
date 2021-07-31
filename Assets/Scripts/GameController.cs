using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
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
    public static bool isAddressAvailable = false;

    public static bool isPostSent = false;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
            Instance = this;

        if(PlayerPrefs.GetInt("LoadGameFirstTime",0) == 0)
        {
            //Set first values for the game
            PlayerPrefs.SetInt("LoadGameFirstTime", 1);


            PlayerPrefs.SetInt("Selected", 0);
            PlayerPrefs.SetInt("Interview", 0);


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

            PlayerPrefs.SetInt("Address_ID", 0);
            PlayerPrefs.SetInt("Course_ID", 0);
            PlayerPrefs.SetInt("College_ID", 0);
            PlayerPrefs.SetInt("isFack_ID", 0);


        }

        if(PlayerPrefs.GetString(post_CV) != null)
        {
            isCVCreated = true;
        }
        if (PlayerPrefs.GetString(post_LOM) != null)
        {
            isLOMCreated = true;
        }
        if (PlayerPrefs.GetString(post_StudyCertificate) != null)
        {
            isStudyCerttificatCreated = true;
        }



    }

    public void ResetGameData()
    {
        //Set first values for the game
        PlayerPrefs.SetInt("LoadGameFirstTime", 1);

        PlayerPrefs.SetInt("Selected", 0);
        PlayerPrefs.SetInt("Interview", 0);

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

        PlayerPrefs.SetInt("Address_ID", 0);
        PlayerPrefs.SetInt("Course_ID", 0);
        PlayerPrefs.SetInt("College_ID", 0);
        PlayerPrefs.SetInt("isFack_ID", 0);

        

    }

    public void DeleteFullData()
    {
        ResetGameData();
        if (File.Exists(Application.persistentDataPath + "/userprofilecontainer.dat"))
        {
            File.Delete(Application.persistentDataPath + "/userprofilecontainer.dat");
        }
    }
}
