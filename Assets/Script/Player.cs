using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //���s���x
    private float speed = 0.03f;
    //��]���x
    private float rotateSpeed = 0.3f;
    //�����A����
    private float horizonalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        horizonalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //���͂�����Έړ�
        if(verticalInput != 0 )
        {
            transform.position += transform.forward * speed * verticalInput;
        }

        //��]
        transform.Rotate(new Vector3(0.0f, rotateSpeed * horizonalInput, 0.0f));
    }
}
