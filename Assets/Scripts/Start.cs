using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;

    void Update ()
    {
        if(GrabAction.GetStateUp(HandType))
        {
            SceneManager.LoadScene("BalloonShooting");
        }
    }
}
