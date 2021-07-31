using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayProfile : MonoBehaviour
{

    public Text nametxt;
    public Text emailtxt;
    public Text gendertxt;
    public Text phonetxt;
    public Text educationtxt;
    public Text coursetxt;
    public Text yearPassingtxt;
    public Text studentIdtxt;
    public Text skillstxt;


    // Start is called before the first frame update
    void OnEnable()
    {
        nametxt.text = "Name : " + CreateProfile.Instance.userProfile.name;
        emailtxt.text = "Email : " + CreateProfile.Instance.userProfile.email;
        gendertxt.text = "Gender : " + CreateProfile.Instance.userProfile.gender;
        phonetxt.text = "Phone : " + CreateProfile.Instance.userProfile.phone;
        educationtxt.text = "Education : " + CreateProfile.Instance.userProfile.study;
        coursetxt.text = "Course : " + CreateProfile.Instance.userProfile.course;
        yearPassingtxt.text = "Year of Passing : " + CreateProfile.Instance.userProfile.batchYear;
        studentIdtxt.text = "Student ID : " + CreateProfile.Instance.userProfile.studentID;
        skillstxt.text = "Skills : " + CreateProfile.Instance.userProfile.skillset;
    }

}
