using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public bool GameCrear;//�Q�[���N���A�t���O
    private GameObject cleartext;

    /// <summary>
    /// �X�^�[�g
    /// </summary>
    void Start()
    {
        GameCrear = false;
        cleartext = GameObject.Find("ClearText");
    }

    /// <summary>
    /// �X�V
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
