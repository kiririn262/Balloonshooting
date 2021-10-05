using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class Shooting : MonoBehaviour {
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;
    public SteamVR_Action_Boolean GrabAction2;

     public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;

    public GameObject obj;

    private TextMeshPro TMP;

    void Start()
    {
        TMP = obj.GetComponent<TextMeshPro>();
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.Mouse0))
        if(GrabAction.GetState(HandType))
        {

            shotInterval += 1;

            if (shotInterval % 5 == 0 && shotCount > 0)
            {
                shotCount -= 1;
                setbullet(shotCount);
                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 3.0f);
            }

        }
        else if (GrabAction2.GetState(HandType))
        {
            shotCount = 30;
            setbullet(shotCount);
        }

    }

    void setbullet(int num){
        TMP.text = "";
        for(int i = num ; i > 0 ; i-- ){
            if(i == 15){
                TMP.text += "\n";
            }
            TMP.text += "|";
        }
    }
}