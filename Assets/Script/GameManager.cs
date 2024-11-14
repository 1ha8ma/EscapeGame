using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool GameCrear;
    Player player;

    void Start()
    {
        GameCrear = false;
        player = GetComponent<Player>();
    }

    void Update()
    {
        if (GameCrear)
        {
            Debug.Log("GameCrear");
        }
    }
}
