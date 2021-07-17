using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;


public class CreateProfile : MonoBehaviour
{
    public static CreateProfile Instance;
    //Input Fields
    public InputField pname;
    public InputField email;
    public InputField phone;
    public Dropdown gender;
    public Dropdown study;
    public Dropdown course;

    public Text skillsset;

    //Please make sure to match this data with dropdown coursebox
    string[] skillData = { "Programing , Web Designing", "Game Play Programming , Game Design", "Game Design, Game Arts , 3D" };
    string userSkill = "";


    //Profile Info
    public ProfileContainer userProfile;

    public string playerName  = "";

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        LoadProfileData();
    }
    // Start is called before the first frame update
    void Start()
    {
        skillsset.text = skillData[0];
        userSkill = skillData[0];
    }
 
    public void OnCourseChange()
    {
        //updating skills according to course
        skillsset.text = skillData[course.value];
        userSkill = skillData[course.value];
    }

    //Saving Profile in persistent data
    public void SaveProfile()
    {
        //If game restarts data will be deleted to create fresh data
        if (File.Exists(Application.persistentDataPath + "/userprofilecontainer.dat"))
        {
            File.Delete(Application.persistentDataPath + "/userprofilecontainer.dat");
        }

        //create and store data into file formate
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath +"/userprofilecontainer.dat", FileMode.Create);
        ProfileContainer pc = new ProfileContainer();

        pc.name = pname.text;
        pc.email = email.text;
        pc.phone = phone.text;
        pc.gender = gender.captionText.text;
        pc.study = study.captionText.text;
        pc.course = course.captionText.text;
        
        pc.skillset = userSkill;

        //These below elements will to create certificate in Educational Institute
        pc.batchYear = Random.Range(2010, 2021); //Create random year of passing
        pc.studentID = Random.Range(150301, 150400); //Create randon student ID
        
        bf.Serialize(file, pc);
        file.Close();
        LoadProfileData();
    }

    public void LoadProfileData()
    {
        if (File.Exists(Application.persistentDataPath + "/userprofilecontainer.dat"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/userprofilecontainer.dat", FileMode.Open);
            ProfileContainer pc = (ProfileContainer)bf.Deserialize(file);
            file.Close();

            userProfile.name = pc.name;
            userProfile.email = pc.email;
            userProfile.phone = pc.phone;
            userProfile.gender = pc.gender;
            userProfile.study = pc.study;
            userProfile.course = pc.course;
            userProfile.skillset = pc.skillset;
            userProfile.batchYear = pc.batchYear;
            userProfile.studentID = pc.studentID;

            //Get username for dialogues
            playerName = pc.name.ToString();
        }
        else
        {
            Debug.Log("Data not found");
        }
    }    

    public void DeleteProfile()
    {
        //Delete profile when you restart game
       
        
    }
}
[System.Serializable]
public class ProfileContainer
{
    public string name;
    public string email;
    public string phone;
    public string course;
    public string gender;
    public string study;
    public string skillset;
    public int batchYear;
    public int studentID;
}
