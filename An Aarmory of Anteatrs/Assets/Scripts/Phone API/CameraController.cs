using System.Collections;
using System.Collections.Generic;

using UnityEngine;

#if UNITY_ANDROID
using UnityEngine.Android;

using ZXing;
#endif

public class CameraController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Foo!");
#if UNITY_ANDROID
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }
#endif
    }

    void Update()
    {
        
    }
}
