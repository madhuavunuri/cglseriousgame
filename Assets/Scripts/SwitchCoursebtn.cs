using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchCoursebtn : MonoBehaviour
{
    public Text numbertxt;

    public int courseTab = 0;

    public void SwitchTab()
    {
        for (int i = 0; i < InternetHubManager.Instance.courseUiObjects.Length; i++)
        {
            InternetHubManager.Instance.courseUiObjects[i].gameObject.SetActive(false);
        }
        InternetHubManager.Instance.courseUiObjects[courseTab].gameObject.SetActive(true);
    }

}
