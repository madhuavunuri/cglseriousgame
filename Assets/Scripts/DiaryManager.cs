using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DiaryManager : MonoBehaviour
{
    public Text adressTxt;
    public Text aplicationInfotxt;
    public Text calendertxt;
    public Text courseTxt;
    // Start is called before the first frame update
    void Awake()
    {

        if (PlayerPrefs.GetString(GameController.diary_address, "") != null || PlayerPrefs.GetString(GameController.diary_address, "") != "")
            adressTxt.text = PlayerPrefs.GetString(GameController.diary_address);
        else
            adressTxt.text = "Not Available";

        if (PlayerPrefs.GetString(GameController.diary_application, "") != null || PlayerPrefs.GetString(GameController.diary_application, "") != "")
            aplicationInfotxt.text = PlayerPrefs.GetString(GameController.diary_application);
        else
            aplicationInfotxt.text = "Not Available";

        if (PlayerPrefs.GetString(GameController.diary_deadline, "") != null || PlayerPrefs.GetString(GameController.diary_deadline, "") != "")
            calendertxt.text = PlayerPrefs.GetString(GameController.diary_deadline);
        else
            calendertxt.text = "Not Available";

        if (PlayerPrefs.GetString(GameController.diary_course, "") != null || PlayerPrefs.GetString(GameController.diary_course, "") != "")
            courseTxt.text = PlayerPrefs.GetString(GameController.diary_course);
        else
            courseTxt.text = "Not Available";
    }


}
