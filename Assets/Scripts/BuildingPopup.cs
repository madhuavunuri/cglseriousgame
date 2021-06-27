using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPopup : MonoBehaviour
{
    public GameObject enterbutton;
    private void Start()
    {
        enterbutton.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enterbutton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enterbutton.SetActive(false);
        }
    }

    public void EnterBuilding()
    {
        CharacterMovement.isAvailable = false;
    }

    public void ExitBuilding()
    {
        CharacterMovement.isAvailable = true;
    }
}
