using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddAges : MonoBehaviour
{
    Dropdown mydrop;
    void Start()
    {

        List<string> list = new List<string>();
        mydrop = GetComponent<Dropdown>() ;
        for (int i=18; i<100; i++) {
            list.Add(i.ToString());
        }
        mydrop.AddOptions(list);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
