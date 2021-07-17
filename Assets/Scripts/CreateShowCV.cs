using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateShowCV : MonoBehaviour
{
    
    public Dropdown hobbies;
    public Dropdown extraCir;

    public Text cvDatatxt;

    string cvData = null; 
    // Start is called before the first frame update
    void OnEnable()
    {
        if (cvData != null)
            cvDatatxt.text = cvData;
        else
            cvDatatxt.text = "Create CV";
    }
    public void CreateCV()
    {
        GameController.isCVCreated = true;
        
        cvData = "Name : " + CreateProfile.Instance.userProfile.name + "\n" +
                  "Skills : " + CreateProfile.Instance.userProfile.skillset + "\n" +
                  "Extra : "+"\n"+hobbies.captionText.text+"\n"+ extraCir.captionText.text;
        cvDatatxt.text = cvData;
        PlayerPrefs.SetString(GameController.post_CV, cvData);
    }
}
