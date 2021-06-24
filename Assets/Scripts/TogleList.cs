using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class TogleList : MonoBehaviour
{
    public int maxTogles;
    int currentTogles;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tickeme()
    {
        string mytext = this.GetComponent<Label>().text;
        UnityEngine.UI.Toggle myTogle = this.GetComponent<UnityEngine.UI.Toggle>();
        
        

        if (currentTogles <= maxTogles)
        {
            if (myTogle.isOn) { currentTogles++; } else { currentTogles--; }
        }


        if (currentTogles == maxTogles)
        {
            //block the rest
        }

    }

}
