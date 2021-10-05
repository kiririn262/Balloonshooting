using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using UnityEngine.SceneManagement;
public class Clear : MonoBehaviour
{
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;
    public SteamVR_Action_Boolean GrabAction2;

     //カウントダウン
    public float countdown = 3.0f;

    void Update ()
    {
        if (countdown > 0){
        //時間をカウントダウンする
        countdown -= Time.deltaTime;
        }
        //countdownが0以下になったとき
        else
        {
            if (GrabAction.GetStateUp(HandType))
            {
                SceneManager.LoadScene("Home");
            }
            else if(GrabAction2.GetStateUp(HandType))
            {
                SceneManager.LoadScene("BalloonShooting");
            }
        }
    }
}
