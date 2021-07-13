using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum InfoSkillType
{
    Analyser,
    Communicator,
    Discoverer,
    DecisionMaker
}
public class InfoLiterracySkills : MonoBehaviour
{
    public static InfoLiterracySkills Instance;

    public int max_SkillValue = 4;


    //UI objects
    public Image analyserBar;
    public Image communicatorBar;
    public Image discovererBar;
    public Image dicisionmakerBar;



    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        
        UpdateSkillBars();
    }
    void UpdateSkillBars()
    {
        //UI image fill bars 
        analyserBar.fillAmount = GetSkillValue(InfoSkillType.Analyser) / max_SkillValue;
        communicatorBar.fillAmount = GetSkillValue(InfoSkillType.Communicator) / max_SkillValue;
        discovererBar.fillAmount = GetSkillValue(InfoSkillType.Discoverer) / max_SkillValue;
        dicisionmakerBar.fillAmount = GetSkillValue(InfoSkillType.DecisionMaker) / max_SkillValue;

    }

    public void IncreaseSkillType(InfoSkillType skill_type,int s_value)
    {
        //Increase Skill value
        if(GetSkillValue(skill_type) < max_SkillValue)
            PlayerPrefs.SetInt("Save" + skill_type.ToString(), GetSkillValue(skill_type) + s_value);

        UpdateSkillBars();

        /*  switch (skill_type)
          {
              case InfoSkillType.Analyser:
                  break;
              case InfoSkillType.Communicator:
                  break;
              case InfoSkillType.Discoverer:
                  break;
              case InfoSkillType.DecisionMaker:
                  break;
              default:
                  break;
          }
        */


    }

    public int GetSkillValue(InfoSkillType skill_type)
    {
        return PlayerPrefs.GetInt("Save" + skill_type.ToString());
    }
}