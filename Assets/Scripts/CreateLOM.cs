using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateLOM : MonoBehaviour
{
    public Dropdown course;
    public Dropdown college;

    public Text lomDatatxt;

    string lomData = null;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (lomData != null)
            lomDatatxt.text = lomData;
        else
            lomDatatxt.text = "Create CV";
    }
    public void Create_LOM()
    {
        GameController.isLOMCreated = true;

        lomData = "Name : " + CreateProfile.Instance.userProfile.name + "\n" +
                  "Course : " + course.captionText.text + "\n" +
                  "College : "  + college.captionText.text;
        lomDatatxt.text = lomData;
        PlayerPrefs.SetString(GameController.post_LOM, lomData);
    }

}
