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
}
