using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    /// <summary>
    /// 更新
    /// </summary>
    public void Update()
    {
        //回転(Space.Worldはワールド座標を基準にした回転)
        Transform mytransform = transform;
        mytransform.Rotate(0.0f, 0.1f, 0.0f, Space.World);
    }
}
