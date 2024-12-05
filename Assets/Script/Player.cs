using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //���s���x
    private float speed = 0.03f;
    //��]���x
    private float rotateSpeed = 0.3f;
    //�����A����
    private float horizonalInput;
    private float verticalInput;
    //�A�j���[�^�[
    private Animator animator = null;

    //�������
    private int GetKeyNum;

    /// <summary>
    /// �X�^�[�g
    /// </summary>
    void Start()
    {
        animator = GetComponent<Animator>();

        GetKeyNum = 0;
    }

    /// <summary>
    /// �X�V
    /// </summary>
    void Update()
    {
        horizonalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //���͂�����Έړ�
        if (verticalInput != 0)
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

    /// <summary>
    /// �I�u�W�F�N�g�ɓ���������
    /// </summary>
    /// <param name="collision">���������I�u�W�F�N�g�̏��</param>
    private void OnCollisionEnter(Collision collision)
    {
        //�Q�[�g�̏ꍇ
        if (collision.gameObject.name == "Gate" && GetKeyNum == 5)
        {
            
            GameManager.GameCrear = true;
        }
        //���̏ꍇ
        if (collision.gameObject.name == ("Key1")|| collision.gameObject.name == ("Key2")|| collision.gameObject.name == ("Key3")|| collision.gameObject.name == ("Key4")|| collision.gameObject.name == ("Key5"))
        {
            Debug.Log("KEY HIT");
            GetKeyNum++;
            //�����폜
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
        //UFO�̏ꍇ
        if (collision.gameObject.name == "UFO1" || collision.gameObject.name == "UFO2")
        {
            Debug.Log("UFO HIT");
            //�Q�[���I�[�o�[
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
