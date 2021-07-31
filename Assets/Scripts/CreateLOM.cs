using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateLOM : MonoBehaviour
{
    public UniversitiesData uniData;
    public Dropdown course;
    public Dropdown college;

    public Text lomDatatxt;

    string lomData = null;
    public int[] Ids;
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

        
        for (int i = 0; i < uniData.uniDetails.Length; i++)
        {
            if(uniData.uniDetails[i].collegeName == college.captionText.text)
            {
                PlayerPrefs.SetInt("College_ID", uniData.uniDetails[i].ID);
            }

            if (uniData.uniDetails[i].course == course.captionText.text)
            {
                PlayerPrefs.SetInt("Course_ID", uniData.uniDetails[i].ID);
            }

            print("Cour - " + PlayerPrefs.GetInt("Course_ID") + "Coll - " + PlayerPrefs.GetInt("College_ID"));

        }
        lomDatatxt.text = lomData;
        PlayerPrefs.SetString(GameController.post_LOM, lomData);
      

        
    }

}
