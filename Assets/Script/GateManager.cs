using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    private float vx = -0.03f;//移動速度

   /// <summary>
   /// 更新
   /// </summary>
    void Update()
    {
        //クリアしていたら左にずらす
        if(GameManager.GameCrear)
        {
            Vector3 position = transform.position;
            if (position.x > 200)
            {
                position.x += vx;
            }

            transform.position = position;
        }
    }
}
