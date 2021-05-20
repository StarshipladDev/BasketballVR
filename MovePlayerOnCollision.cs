using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerOnCollision : MonoBehaviour
{
    public bool MovePlayer = false;
    public bool bounced = false;
    public bool letGo = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
        if (MovePlayer)
        {

            GameObject playerVR = GameObject.Find("XrRig");
            GameObject cam = GameObject.Find("Camera");
            GameObject ball = GameObject.Find("Basketball");
            /*
             * 
             * 
            Vector3 targetDirection = new Vector3(0.0f, 0f, 0.0f);
            targetDirection = cam.transform.TransformDirection(targetDirection);
            targetDirection.y = 0.0f;*/
            //playerVR.transform.Translate(playerVR.transform.rotation * Vector3.forward );
            // This one playerVR.transform.Translate(0, 0, 0.2f, Space.Self);
            //playerVR.transform.Translate(targetDirection *1.0f); 
            //playerVR.transform.localRotation = cam.transform.rotation;
            //cam.transform.rotation = Quaternion.Euler(0,0,0);
            float oldy = playerVR.transform.position.y;
            print("XYZ pre bounce is "+ playerVR.transform.position.x+" "+ playerVR.transform.position.y+" "+ playerVR.transform.position.z);
            playerVR.transform.Translate(cam.transform.rotation * Vector3.forward  * 0.5f);
            print("XYZ after move, before resetting Y " + playerVR.transform.position.x + " " + playerVR.transform.position.y + " " + playerVR.transform.position.z);
            playerVR.transform.position = new Vector3(playerVR.transform.position.x, oldy, playerVR.transform.position.z);
            print("XYZ afer resetting Y " + playerVR.transform.position.x + " " + playerVR.transform.position.y + " " + playerVR.transform.position.z);
            
            MovePlayer = false;
            bounced = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Basketball"))
        {

            UnityEngine.Debug.Log("BASKETBALL COLLIDER TRIGGERED");
            GameObject basketball = GameObject.Find("Basketball");
            GameObject playerVR = GameObject.Find("Offset");
            //If ball clsoe enough to player
            if ((Math.Abs(playerVR.transform.position.x - basketball.transform.position.x) < 1.8f) && (Math.Abs(playerVR.transform.position.z - basketball.transform.position.z) < 1.8f))
            {
                UnityEngine.Debug.Log("Actioning!");
                UnityEngine.Debug.Log("x,z is" + playerVR.transform.position.x + " , " + playerVR.transform.position.z + ". Difference is " + Math.Abs(playerVR.transform.position.x - basketball.transform.position.x) + "," + Math.Abs(playerVR.transform.position.z - basketball.transform.position.z));

                if (letGo && bounced == false)
                {
                    UnityEngine.Debug.Log("Let Go true, running!");
                    MovePlayer = true;
                }
                else
                {

                    UnityEngine.Debug.Log("Let Go is " +letGo.ToString() +", staying still!");
                }

            }
            else
            {
                UnityEngine.Debug.Log("Ball Not Close Enough");
            }
            
        }
    }
    public void LetGo()
    {
        letGo = true;

    }
    public void Grab()
    {
        bounced = false;
        letGo = false;
    }
 }
