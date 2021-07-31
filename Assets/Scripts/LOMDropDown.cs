using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOMDropDown : MonoBehaviour
{
    public string inftype = "";
    public UniversitiesData uniData;
    // Start is called before the first frame update
    void OnEnable()
    {
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();

        List<string> items = new List<string>();
        if(inftype == "College")
        {
            for (int i = 0; i < uniData.uniDetails.Length; i++)
            {
                items.Add(uniData.uniDetails[i].collegeName);
                
            }
        }
        else
        {
            for (int i = 0; i < uniData.uniDetails.Length; i++)
            {
                items.Add(uniData.uniDetails[i].course);
            }
        }
        

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() 
            { 
                text = item 
            });
           
        }
      
    }

    void DropDoenItem(Dropdown dropdown)
    {
        int index = dropdown.value;

    }
}
