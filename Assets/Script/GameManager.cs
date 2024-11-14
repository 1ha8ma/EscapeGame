using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool GameCrear;//ゲームクリアフラグ

    /// <summary>
    /// スタート
    /// </summary>
    void Start()
    {
        GameCrear = false;
    }

    /// <summary>
    /// 更新
    /// </summary>
    void Update()
    {
        if (GameCrear)
        {
            Debug.Log("GameCrear");
        }
    }
}
