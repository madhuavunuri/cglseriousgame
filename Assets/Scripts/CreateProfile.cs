using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateProfile : MonoBehaviour
{
    public new InputField name;
    public Dropdown education;
    public Dropdown sex;
    public Dropdown age;
    public PlayerProfile profile;
    

    public void fillProfile()
    {
        profile.name = name.text;
        profile.education = education.value;// profile.education = education.options[education.value].text;
        profile.sex = sex.value;
        profile.age = age.value;
    }


    public void loadProfile()
    {
        name.text = profile.name;
        education.value = profile.education;
        sex.value = profile.sex;
        age.value = profile.age;

    }

}
