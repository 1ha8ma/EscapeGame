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

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
            animator.SetBool("Walk", true);
        }
        else 
        {
            animator.SetBool("Walk", false);
        }

        //��]
        transform.Rotate(new Vector3(0.0f, rotateSpeed * horizonalInput, 0.0f));
    }
}
