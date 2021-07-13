using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;
public class PopupDialogue : MonoBehaviour
{

    //Stored current Dialogue object or person
    VIDE_Assign inTrigger;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<VIDE_Assign>() != null)
            inTrigger = other.GetComponent<VIDE_Assign>();
    }

    void OnTriggerExit()
    {
        inTrigger = null;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartTalking();
        }
    }
    public void StartTalking()
    {

        if (inTrigger)
        {
            DialogueManager.Instance.Interact(inTrigger);
         
        }

      
    }

}
