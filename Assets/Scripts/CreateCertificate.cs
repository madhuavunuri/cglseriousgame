using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateCertificate : MonoBehaviour
{
    public GameObject contentObj;
    public Dropdown batchYear;
    public Dropdown studentID;


    public Text studyDatatxt;
    public Text responceTxt;
    string studyData = null;

    public GameObject SearchCertificateBtn;

    // Start is called before the first frame update
    void OnEnable()
    {
        contentObj.SetActive(false);
        if (studyData != null)
        {
            studyDatatxt.text = studyData;
            SearchCertificateBtn.SetActive(false);
        }
        else
            studyDatatxt.text = "Get your certificate with correct year and ID";

        

        responceTxt.text = "Get Your Certificate";
        batchYear.options.Clear();
        studentID.options.Clear();

        List<string> yearItems = new List<string>();
        List<string> IDItems = new List<string>();

        for (int i = 2010; i < 2021; i++)
        {
            yearItems.Add(i.ToString());
        }
        for (int i = 150301; i < 150400; i++)
        {
            IDItems.Add(i.ToString());
        }

        foreach (var item in yearItems)
        {
            batchYear.options.Add(new Dropdown.OptionData() { text = item });
        }
        foreach (var item in IDItems)
        {
            studentID.options.Add(new Dropdown.OptionData() { text = item });
        }
    }

    public void Get_Certificate()
    {
        if(CreateProfile.Instance.userProfile.batchYear.ToString() == batchYear.captionText.text &&
            CreateProfile.Instance.userProfile.studentID.ToString() == studentID.captionText.text)
        {
            GameController.isStudyCerttificatCreated = true;

            studyData = "Name : " + CreateProfile.Instance.userProfile.name + "\n" +
                        "Course : " + CreateProfile.Instance.userProfile.course + "\n" +
                        "Year : " + CreateProfile.Instance.userProfile.batchYear + "\n" +
                        "Student ID : " + CreateProfile.Instance.userProfile.studentID;

            studyDatatxt.text = studyData;
            PlayerPrefs.SetString(GameController.post_StudyCertificate, studyData);
            contentObj.SetActive(false);
            SearchCertificateBtn.SetActive(false);

        }
        else
        {
            responceTxt.text = "Please choose correct details of Year and your ID";

        }

    }

}
