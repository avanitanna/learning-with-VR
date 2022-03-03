/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Oculus.Voice.Demo.UIShapesDemo;

public class HandController : MonoBehaviour
{

    private InputDevice targetDevice;
    private bool active = false;
    public GameObject interactionsHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics =
            InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float enableValue);
        
        if ((enableValue > 0.1f && !active) || Input.GetKeyDown(KeyCode.M))
        {
            interactionsHandler.GetComponent<InteractionHandler>().ToggleActivation();
            active = true;
        }

    }
}

*/