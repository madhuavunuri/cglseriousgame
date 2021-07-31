using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    public float followSpeed = 5;
    private Vector3 offset;
    bool rorateCam = false;
    // Start is called before the first frame update
    void Start()
    {
        offset = followTarget.position - transform.position;
  
    }

    // Update is called once per frame
    void Update()
    {
     
        if (followTarget)
        {
            if(this.gameObject.tag == "MainCamera")//rorateCam)
            {
               // Vector3 relativePos = followTarget.position - transform.position;
               // Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
               // transform.rotation = rotation;

                print(transform.rotation);
               // print(relativePos);

            }
            else
            {
                //transform.position = followTarget.position - offset;
            }
            


        }
    }

    public void RotateCamera()
    {
        if(!rorateCam)
        {
            rorateCam = true;
        }
    }
}
