using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public bool GameCrear;//ゲームクリアフラグ
    private GameObject cleartext;

    /// <summary>
    /// スタート
    /// </summary>
    void Start()
    {
        GameCrear = false;
        cleartext = GameObject.Find("ClearText");
    }

    /// <summary>
    /// 更新
    /// </summary>
    void Update()
    {
        if (GameCrear)
        {
            cleartext.SetActive(true);
            Debug.Log("GameCrear");
        }
        else
        {
            cleartext.SetActive(false);
        }
    }
}
