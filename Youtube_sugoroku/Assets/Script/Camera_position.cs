using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_position : MonoBehaviour
{
    [SerializeField] float x, y, z;
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(x, y, z);
    }
}
