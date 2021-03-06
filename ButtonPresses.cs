﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

using UnityEngine.SceneManagement;
public class ButtonPresses : MonoBehaviour
{

    private InputDevice rightController;
    bool lazerOut = true;
    public GameObject myPrefab;
    bool hasLoaded = false;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDeviceCharacteristics RightChar = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(RightChar, inputDevices);
        foreach (var item in inputDevices)
        {
            UnityEngine.Debug.Log("Item :" + item.name);
        }
        if (inputDevices.Count > 0)
        {
            rightController = inputDevices[0];
        }

    }
    



    // Update is called once per frame
    void Update()
    {
        rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if (primaryButtonValue)
        {
            swapRay();
        }
        rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButton);
        if (primaryButtonValue)
        {
            if (lazerOut)
            {
                Destroy(GameObject.Find("lazer"));
                lazerOut = false;
            }
            Scene scene = SceneManager.GetActiveScene();
            if (!hasLoaded && scene.name !=null && scene.name != "Scene2")
            {
                SceneManager.LoadScene(1);
                hasLoaded = true;
            }
        }
    }

    void swapRay()
    {
        Debug.Log("Button pressed!");
        if (lazerOut)
        {
            Destroy(GameObject.Find("lazer"));
            lazerOut = false;
        }
        else
        {
            // Instantiate at position (0, 0, 0) and zero rotation.
            lazerOut = true;
            GameObject playerVR = GameObject.Find("Offset");
            GameObject lazer = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            lazer.transform.SetParent(playerVR.transform, false);
            lazer.name = "lazer";
        }
    }
}
