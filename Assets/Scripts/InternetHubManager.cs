using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InternetHubManager : MonoBehaviour
{
    public static InternetHubManager Instance;


    //Universities information Display
    public UniversitiesData uniInfo;
    public DisplayUniObj uniObjPrefab;
    public DisplayUniObj[] courseUiObjects;
    public Transform contentParent;

    public GameObject courseBtnPrefab;
    public Transform courseBtnParent;

    //Email System
    public Button emailBtn;
    public Text application_messgae;
    public Text emaiBtnTxt;
    public GameObject attendInterviewBtn;
    public GameObject FinishGameBtn;
    public GameObject EmailCloseBtn;

    //Interview 
    public GameObject InterviewPannel;

    private void Awake()
    {
        //Instance object for this InternetHubManager
        if (Instance == null)
            Instance = this;

    }

    private void OnEnable()
    {
        if(GameController.isPostSent)
        {
            emaiBtnTxt.text = "Open";
            emailBtn.interactable = true;
        }
        else
        {
            emailBtn.interactable = false;
            emaiBtnTxt.text = "Locked";
        }
    }
    void Start()
    {
        
        courseUiObjects = new DisplayUniObj[uniInfo.uniDetails.Length];
        //Load and create uni objects in UI
        for (int i = 0; i < uniInfo.uniDetails.Length; i++)
        {
            DisplayUniObj obj = Instantiate(uniObjPrefab, contentParent);

            obj.collegeNametxt.text = uniInfo.uniDetails[i].collegeName;
            obj.courseTxt.text = uniInfo.uniDetails[i].course;
            obj.addressTxt.text = uniInfo.uniDetails[i].address;
            obj.infotxt.text = uniInfo.uniDetails[i].info;
            obj.requirmentstxt.text = uniInfo.uniDetails[i].requriments;
            obj.deadLine = uniInfo.uniDetails[i].deadline;
            obj.ID = uniInfo.uniDetails[i].ID;
            obj.isfack = uniInfo.uniDetails[i].isFack;

            courseUiObjects[i] = obj;
           
            if (i > 0)
                obj.gameObject.SetActive(false);

            GameObject Btnobj = Instantiate(courseBtnPrefab, courseBtnParent);
            Btnobj.GetComponent<SwitchCoursebtn>().courseTab = i;
            Btnobj.GetComponent<SwitchCoursebtn>().numbertxt.text = (i+1).ToString();// "Course "+i;

        }
    }
    public void SwitchTab(GameObject courseTab)
    {
        for(int i = 0; i< courseUiObjects.Length;i++)
        {
            courseUiObjects[i].gameObject.SetActive(false);
        }
        courseTab.gameObject.SetActive(true);
    }

    public void OpenEmail()
    {
        attendInterviewBtn.SetActive(false);
        EmailCloseBtn.SetActive(true);
        FinishGameBtn.SetActive(false);

        if (PlayerPrefs.GetInt("isFack_ID", 0) == 0)
        {
            application_messgae.text = "Rejected" + "\n" + "Fake Info";
            PlayerPrefs.SetInt("Selected", 0);
        }
        else if (PlayerPrefs.GetInt("Course_ID", 0) != PlayerPrefs.GetInt("College_ID", 0))
        {
            application_messgae.text = "Rejected"+"\n"+"Wrong LOM";
            PlayerPrefs.SetInt("Selected", 0);
        }
        else if(PlayerPrefs.GetInt("Course_ID", 0) != PlayerPrefs.GetInt("Address_ID", 0))
        {
            application_messgae.text = "Rejected" + "\n" + "Wrong Address";
            PlayerPrefs.SetInt("Selected", 0);
        }   
        else
        {
            PlayerPrefs.SetInt("Selected", 1);
            application_messgae.text = "Selected";
        }


        if(PlayerPrefs.GetInt("Selected") != 0)
        {
            attendInterviewBtn.SetActive(true);
            EmailCloseBtn.SetActive(true);
            FinishGameBtn.SetActive(false);
        }
        else
        {
            attendInterviewBtn.SetActive(false);
            EmailCloseBtn.SetActive(false);
            FinishGameBtn.SetActive(true);
        }
    }
}
