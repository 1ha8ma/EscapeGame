using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    private float vx = -0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�N���A���Ă����獶�ɂ��炷
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
