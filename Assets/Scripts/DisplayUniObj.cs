using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayUniObj : MonoBehaviour
{
    public Text collegeNametxt;
    public Text courseTxt;
    public Text addressTxt;
    public Text requirmentstxt;
    public Text infotxt;
    public int deadLine;

    public void OpenCloseSavebtn(GameObject btn)
    {
        if (btn.activeSelf)
            btn.SetActive(false);
        else
            btn.SetActive(true);
    }

    public void SaveAddress()
    {
        PlayerPrefs.SetString(GameController.diary_address, addressTxt.text);
        GameController.isAddressAvailable = true;
    }
    public void SaveCourse()
    {
        PlayerPrefs.SetString(GameController.diary_course, courseTxt.text);
    }
    public void SaveApplication()
    {
        PlayerPrefs.SetString(GameController.diary_application, requirmentstxt.text);
    }
    public void SaveDeadLine()
    {
        PlayerPrefs.SetString(GameController.diary_deadline, "DeadLine days : " + deadLine.ToString());

    }
}
