using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    /// <summary>
    /// �X�V
    /// </summary>
    public void Update()
    {
        //��](Space.World�̓��[���h���W����ɂ�����])
        Transform mytransform = transform;
        mytransform.Rotate(0.0f, 0.1f, 0.0f, Space.World);
    }
}
