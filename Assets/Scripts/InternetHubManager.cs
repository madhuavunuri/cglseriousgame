using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Awake()
    {
        //Instance object for this InternetHubManager
        if (Instance == null)
            Instance = this;

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
            courseUiObjects[i] = obj;
           
            if (i > 0)
                obj.gameObject.SetActive(false);

            GameObject Btnobj = Instantiate(courseBtnPrefab, courseBtnParent);
            Btnobj.GetComponent<SwitchCoursebtn>().courseTab = i;
            Btnobj.GetComponent<SwitchCoursebtn>().numbertxt.text = "Course "+i;

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

    
}
