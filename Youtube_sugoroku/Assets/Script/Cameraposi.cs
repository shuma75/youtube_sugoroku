using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraposi : MonoBehaviour
{
    [SerializeField] GameObject train;
    void Update()
    {
        transform.position = train.transform.position;
    }
}
