using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogleList : MonoBehaviour
{
    public int maxTogles;
    public List<Toggle> togs ;
    int currentTogles =0 ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tickeme(Toggle myTogle)
    {
        
        
        if (currentTogles <= maxTogles)
        {
            if (myTogle.isOn) { 
                currentTogles++; 
            } else { 
                currentTogles--; 
            }
        }


        if (currentTogles == maxTogles)
        {
            foreach (Toggle tog in togs)
            {
                if (tog.isOn==false) { tog.interactable = false; }
            }

            //block the rest
        }
        else
        {
            foreach (Toggle tog in togs)
            {
                tog.interactable = true;    
            }
        }

    }

    public void pupu()
    {
        Debug.Log("3wef");
    }

}
