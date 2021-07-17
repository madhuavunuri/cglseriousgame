using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public void DisableWalking()
    {
        CharacterMovement.isAvailable = false;
    }

    public void EnableWalking()
    {
        CharacterMovement.isAvailable = true;
    }
}
