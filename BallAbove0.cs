using System;
using System.Collections;

using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BallAbove0 : MonoBehaviour
{
    int i = 0;
    // Update is called once per frame
    void Update()
    {
        /*
        if (bouncing == false)
        {

            GameObject playerVR = GameObject.Find("Offset");
            if (transform.position.y < 0.2f COMMENT THIS OUT transform.position.y < (playerVR.transform.position.y / 5) || gameObject.Active == true)
            {
                bounceCount++;
            }
            else if(bounceCount>0)
            {
                if (Math.Abs(playerVR.transform.position.x - transform.position.x) < 0.2f && Math.Abs(playerVR.transform.position.z - transform.position.z) < 0.2f)
                {
                    bounceCount = 0;
                    bouncing = true;
                    Animation anim = GetComponent<Animation>();
                    transform.SetParent(playerVR.transform);
                    anim.Play("JumpBball");
                }
            }

        }
        else
        {

            GameObject playerVR = GameObject.Find("Offset");
            playerVR.transform.position += Vector3.forward * Time.deltaTime * 0.5f;
        }
        
        */
        i++;
        if (i > 10)
        {
            i = 0;
            if (transform.position.y < 0)
            {
                transform.position = new Vector3(0, 1,1);
            }
            if (transform.position.x > 30 || transform.position.x < -30 || transform.position.z > 30 || transform.position.z < -30)
            {
                transform.position = new Vector3(0, 1, 1);
            }
        }
    }
}
