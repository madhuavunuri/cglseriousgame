using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetHubManager : MonoBehaviour
{

    public GameObject[] courseObjects;

    public void SwitchTab(GameObject courseTab)
    {
        for(int i = 0; i<courseObjects.Length;i++)
        {
           courseObjects[i].SetActive(false);
        }
        courseTab.gameObject.SetActive(true);
    }

    public void OpenCloseSavebtn(GameObject btn)
    {
        if (btn.activeSelf)
            btn.SetActive(false);
        else
            btn.SetActive(true);
    }

}
