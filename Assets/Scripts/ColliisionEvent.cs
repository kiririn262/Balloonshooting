using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliisionEvent : MonoBehaviour
{
    //ボールが当たった物体の法線ベクトル
    private Vector3 objNomalVector = Vector3.zero;
    // ボールのrigidbody
    private Rigidbody rb;

    bool colFlag=false;
    public int dmg;
    // 跳ね返った後のverocity
    [HideInInspector] public Vector3 afterReflectVero = Vector3.zero;
    // 大きさをInspector上で自由に設定できるようにする
    public Vector3 scale = new Vector3(2.0f, 2.0f, 2.0f);
    private Vector3 flag = new Vector3(1.0f, 1.0f, 1.0f);
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (dmg > 4) Destroy(gameObject);
    }

public void OnCollisionEnter(Collision collision)
    {
        /*Transform t = this.gameObject.GetComponent<Transform>();
        sphere = GameObject.Find("sphere"); //ボールObjectを取ってくる
        Instantiate("new ball", sphere.transform.position + Vector3(10, 0, 10), sphere.transform.rotation);
        new_ball = GameObject.Find("new ball");
        new_ball.rigitbody.AddForce(/*適当に力をかける);*/

        if (collision.gameObject.tag == "Bullet" && !colFlag) {
            /* // 当たった物体の法線ベクトルを取得
             objNomalVector = collision.contacts[0].normal;
             Vector3 reflectVec = Vector3.Reflect(afterReflectVero, objNomalVector);
             rb.velocity = reflectVec;
             // 計算した反射ベクトルを保存
             afterReflectVero = rb.velocity;
             //Debug.Log("nomal:" + afterReflectVero);*/
            Destroy(collision.gameObject);
            colFlag = true;
            GameObject temp;
            for (int i = 0; i < 2; i++) {
                temp = Instantiate(this.gameObject);
                GameObject targets = GameObject.Find("targets");
                temp.transform.parent = targets.transform;
                temp.GetComponent<ColliisionEvent>().dmg ++;
                temp.transform.localScale = new Vector3(transform.localScale.x * 0.8f, transform.localScale.y * 0.8f, transform.localScale.z * 0.8f);
            }
            Destroy(this.gameObject);

        }

    }
}

