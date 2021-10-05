using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveController : MonoBehaviour
{
SteamVR_TrackedObject trackedObj;

void Awake()
{
    trackedObj = GetComponent<SteamVR_TrackedObject>();
}

void Update () {
		
    /*var device = SteamVR_Controller.Input((int)trackedObj.index);
		
    if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
    {
        Debug.Log("GetPressDown Trigger");		
    }*/
/*
  if (SteamVR_Input._default.inActions.GrabGrip.GetStateUp(SteamVR_Input_Sources.Any)) {
    Debug.Log("グリップを離した");
  }
  if (SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any)) {
    Debug.Log("グリップを押した");
  }

  if (SteamVR_Input._default.inActions.GrabGrip.GetState(SteamVR_Input_Sources.Any)) {
    Debug.Log("グリップを押している");
  }
  else {
    Debug.Log("グリップを離している");
  }*/

}
}

