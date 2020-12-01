using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BallAbove0 : MonoBehaviour
{
    int i = 0;
    bool abovePlayerWaist = false;
    bool bouncing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void SetNotBouncing()
    {

        transform.SetParent(null,true);
        bouncing = false;
    }
        // Update is called once per frame
        void Update()
    {
        if (bouncing == false)
        {

            GameObject playerVR = GameObject.Find("Offset");
            if (transform.position.y > (playerVR.transform.position.y / 2))
            {
                abovePlayerWaist = true;

            }
            else
            {
                abovePlayerWaist = false;
                bouncing = true;
                Animation anim = GetComponent<Animation>();
                transform.SetParent(playerVR.transform);
                anim.Play("JumpBball");
            }

        }
        else
        {

            GameObject playerVR = GameObject.Find("Offset");
            playerVR.transform.position += Vector3.forward * Time.deltaTime * 0.5f;
        }
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
