using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("LoadGameFirstTime",0) == 0)
        {
            //Set first values for the game
            PlayerPrefs.SetInt("LoadGameFirstTime", 1);

            //Reset all Information literacy skills for first time loading game
            PlayerPrefs.SetInt("Save" + InfoSkillType.Analyser.ToString(), 0);
            PlayerPrefs.SetInt("Save" + InfoSkillType.Communicator.ToString(), 0);
            PlayerPrefs.SetInt("Save" + InfoSkillType.DecisionMaker.ToString(), 0);
            PlayerPrefs.SetInt("Save" + InfoSkillType.Discoverer.ToString(), 0);
        }
    }

}
