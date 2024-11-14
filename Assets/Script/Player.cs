using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    //歩行速度
    private float speed = 0.03f;
    //回転速度
    private float rotateSpeed = 0.3f;
    //垂直、水平
    private float horizonalInput;
    private float verticalInput;
    //アニメーター
    private Animator animator = null;

    //鍵を入手
    private bool GetKeyflg;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        GetKeyflg = false;
    }

    // Update is called once per frame
    void Update()
    {     
        horizonalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //入力があれば移動
        if (verticalInput != 0)
        {
            transform.position += transform.forward * speed * verticalInput;
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }

        //回転
        transform.Rotate(new Vector3(0.0f, rotateSpeed * horizonalInput, 0.0f));
    }

    //オブジェクトに当たった時
    private void OnCollisionEnter(Collision collision)
    {
        //ゲートの場合
        if (collision.gameObject.name == "Gate" && GetKeyflg)
        {
            Debug.Log("GATE HIT");
            GameManager.GameCrear = true;
        }
        //鍵の場合
        if(collision.gameObject.name =="Key")
        {
            Debug.Log("KEY HIT");
            GetKeyflg = true;
        }
    }
}
