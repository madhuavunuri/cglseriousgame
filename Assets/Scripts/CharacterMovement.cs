﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public static bool isAvailable = true;
    //NavMeshAgent variable control player movement
    public NavMeshAgent playerNavMeshAgent;

    //A Camera that follow player movement
    public Camera playerCamera;

    //Control the animation clips of player object 
    public Animator playerAnimator;

    //check character is running(moving) or not
    public bool isWalking;
    public GameObject naviPointer;

    private void Start()
    {
        isAvailable = false;
      
    }
    // Update is called once per frame
    void Update()
    {

        //if the left button of is clicked
        if (Input.GetMouseButton(0) && isAvailable)
        {
            //Unity cast a ray from the position of mouse cursor on-screen toward the 3D scene.
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

          
            if (Physics.Raycast(myRay, out myRaycastHit))
            {
                //Check are you hitting ground object
                if(myRaycastHit.collider.gameObject.tag == "Ground")
                {
                    //Assign ray hit point as Destination of Navemesh Agent (Player)
                    playerNavMeshAgent.SetDestination(myRaycastHit.point);
                    naviPointer.transform.position = myRaycastHit.point;
                }
                
            }
        }

        //Compare the value of the remaining distance and the stopping distance(Destination point)

        if (playerNavMeshAgent.remainingDistance <= playerNavMeshAgent.stoppingDistance)
        {
            //The remaining distance are less or equal than the stopping distance it means character stop moving and reached destination
            isWalking = false;
        }
        else
        {
            //If remaining distance are greater than the stopping distance than character still moving toward Destination
            isWalking = true;
        }

        playerAnimator.SetBool("isWalking", isWalking);
    }

    
  
}
