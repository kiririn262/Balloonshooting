using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BalloonCounter : MonoBehaviour
{
    private TextMeshPro UIText;
    GameObject[] tagObjects;
    GameObject targets;
    public GameObject TMP;
    public GameObject clear;
    //float timer = 0.0f;
    //float interval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        UIText = TMP.GetComponent<TextMeshPro>();
        targets = GameObject.Find("targets");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(targets.transform.childCount);
        UIText.text = "balloon : " + targets.transform.childCount;
        if(targets.transform.childCount == 0){
            //clear処理
            clear.SetActive(true);
        }

        //timer += Time.deltaTime;
        //if(timer > interval){
        //    Check("Target");
        //    timer = 0;
        //}
    }

    //シーン上のBlockタグが付いたオブジェクトを数える
    /*void Check(string tagname){

        //Debug.Log(tagObjects.Length); //tagObjects.Lengthはオブジェクトの数
        if(targets.transform.childCount == 0){
            //clear処理
            //Debug.Log(tagname + "タグがついたオブジェクトはありません");
        }
    }*/
}