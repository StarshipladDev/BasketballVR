using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerMoveTowards : MonoBehaviour
{
    bool towardPlayer = true;
    bool needsToPlayGaurd = false;
    int counter = 0;
    private Animation gaurdAnimation;
    // Start is called before the first frame update
    void Start()
    {
        //gaurdAnimation = gameObject.GetComponent<Animation>();
        gaurdAnimation = gameObject.GetComponentInChildren<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gaurdAnimation.isPlaying && needsToPlayGaurd == false)
        {
            gaurdAnimation.Play("RunAnimation");
        }
        if (needsToPlayGaurd)
        {
            gaurdAnimation.Play("Scene");
            needsToPlayGaurd = false;
        }
        if (counter < 10)
        {
            counter++;
        }
        else
        {
            var gObj = GameObject.Find("XrRig");
            counter = 0;
            float targetx=gObj.transform.position.x;
            float targetz = gObj.transform.position.z;
            //If far aaway enough to return
            if (! towardPlayer )
            {

                if (Math.Abs(targetx - transform.position.x) > 8.0f && Math.Abs(targetz - transform.position.z) > 8.0f)
                {
                    needsToPlayGaurd = true;
                    towardPlayer = true;
                }
            }
            //If close enough to go away
            if (Math.Abs(targetx - transform.position.x)<0.2f && Math.Abs(targetz - transform.position.z)<0.2f){
                needsToPlayGaurd = true;
                towardPlayer = false;
            }
            if (counter == 9)
            {
                counter = 0;
                UnityEngine.Debug.Log("x,z is" + targetx + " , " + targetz + ". Difference is " + Math.Abs(targetx - transform.position.x) + "," + Math.Abs(targetz - transform.position.z) + " tPlayer is " + towardPlayer);

            }
            if (towardPlayer)
            {
                if (targetx > transform.position.x)
                {
                    transform.Translate(Vector3.right * +.1f);
                }
                else if (targetx < transform.position.x)
                {
                    transform.Translate(Vector3.right * -.1f);

                }
                if (targetz > transform.position.z)
                {
                    transform.Translate(Vector3.forward * +.1f);
                }
                else if (targetz < transform.position.z)
                {
                    transform.Translate(Vector3.forward * -.1f);
                }
            }
            else
            {
                if (targetx > transform.position.x)
                {
                    transform.Translate(Vector3.right * -.1f);
                }
                else if (targetx < transform.position.x)
                {
                    transform.Translate(Vector3.right * +.1f);

                }
                if (targetz > transform.position.z)
                {
                    transform.Translate(Vector3.forward * -.1f);
                }
                else if (targetz < transform.position.z)
                {
                    transform.Translate(Vector3.forward * +.1f);
                }
            }
            

        }
    }
}
