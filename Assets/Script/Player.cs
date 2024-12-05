using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private int GetKeyNum;

    /// <summary>
    /// スタート
    /// </summary>
    void Start()
    {
        animator = GetComponent<Animator>();

        GetKeyNum = 0;
    }

    /// <summary>
    /// 更新
    /// </summary>
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

    /// <summary>
    /// オブジェクトに当たった際
    /// </summary>
    /// <param name="collision">当たったオブジェクトの情報</param>
    private void OnCollisionEnter(Collision collision)
    {
        //ゲートの場合
        if (collision.gameObject.name == "Gate" && GetKeyNum == 5)
        {
            
            GameManager.GameCrear = true;
        }
        //鍵の場合
        if (collision.gameObject.name == ("Key1")|| collision.gameObject.name == ("Key2")|| collision.gameObject.name == ("Key3")|| collision.gameObject.name == ("Key4")|| collision.gameObject.name == ("Key5"))
        {
            Debug.Log("KEY HIT");
            GetKeyNum++;
            //鍵を削除
            if (collision.gameObject.name == ("Key1"))
            {
                GameObject key = GameObject.Find("Key1");
                Destroy(key);
            }
            if (collision.gameObject.name == ("Key2"))
            {
                GameObject key = GameObject.Find("Key2");
                Destroy(key);
            }
            if (collision.gameObject.name == ("Key3"))
            {
                GameObject key = GameObject.Find("Key3");
                Destroy(key);
            }
            if (collision.gameObject.name == ("Key4"))
            {
                GameObject key = GameObject.Find("Key4");
                Destroy(key);
            }
            if (collision.gameObject.name == ("Key5"))
            {
                GameObject key = GameObject.Find("Key5");
                Destroy(key);
            }
        }
        //UFOの場合
        if (collision.gameObject.name == "UFO1" || collision.gameObject.name == "UFO2")
        {
            Debug.Log("UFO HIT");
            //ゲームオーバー
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
