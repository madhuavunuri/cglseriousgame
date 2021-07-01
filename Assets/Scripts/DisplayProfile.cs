using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayProfile : MonoBehaviour
{
    public Text info;
    // Start is called before the first frame update
    void OnEnable()
    {
        info.text = "Name : " + CreateProfile.Instance.userProfile.name + "\n" +
                    "Email : " + CreateProfile.Instance.userProfile.email + "\n" +
                    "Phone : " + CreateProfile.Instance.userProfile.phone + "\n" +
                    "Gender : " + CreateProfile.Instance.userProfile.gender + "\n" +
                    "Education : " + CreateProfile.Instance.userProfile.study + "\n" +
                    "Course : " + CreateProfile.Instance.userProfile.course + "\n" +
                    "Year of Passing : " + CreateProfile.Instance.userProfile.batchYear + "\n" +
                    "Student ID : " + CreateProfile.Instance.userProfile.studentID + "\n" +
                    "Skills : " + CreateProfile.Instance.userProfile.skillset + "\n";
    }

}
