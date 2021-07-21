using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;
public class PopupDialogue : MonoBehaviour
{
    public GameObject sisterTrigger;
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
    public void IntroductionDialogues(VIDE_Assign obj)
    {
        DialogueManager.Instance.Interact(obj);
        inTrigger = obj;
    }

    public void EndsisterDialogue()
    {
        sisterTrigger.SetActive(false);
        inTrigger = null;
    }
}
