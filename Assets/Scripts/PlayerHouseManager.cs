using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHouseManager : MonoBehaviour
{
    public Text studyCertiTxt;
    
    // Start is called before the first frame update
    void OnEnable()
    {
    
        if (GameController.isStudyCerttificatCreated)
        {
            studyCertiTxt.text = PlayerPrefs.GetString(GameController.post_StudyCertificate);
        }
        else
        {
            studyCertiTxt.text = "Empty";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
