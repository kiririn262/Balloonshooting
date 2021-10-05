using UnityEngine;
using Valve.VR;

public class InputTester : MonoBehaviour
{
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;

    void Update ()
    {
        if (GrabAction.GetState(HandType))
        {
            Debug.Log(GrabAction.ToString());
        }
    }
}