using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool GameCrear;//�Q�[���N���A�t���O

    /// <summary>
    /// �X�^�[�g
    /// </summary>
    void Start()
    {
        GameCrear = false;
    }

    /// <summary>
    /// �X�V
    /// </summary>
    void Update()
    {
        if (GameCrear)
        {
            Debug.Log("GameCrear");
        }
    }
}
