
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //checks if device is active and displays its name
      
       if(!XRSettings.isDeviceActive){
         Debug.Log( "No Headset plugged");

       } else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "Mock HMD" 
       || XRSettings.loadedDeviceName == "MockHMD Display"){
         Debug.Log( "Using Mock HMD");
       }
    else {
        Debug.Log("VR Headset name: " + XRSettings.loadedDeviceName );
    }


 
}
}
