using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motion : MonoBehaviour
{
    [SerializeField] float Speed = 2;
    [HideInInspector] public GameObject next_Station;

    private void Start()
    {
        next_Station.transform.position = transform.position;
    }

    void Update()
    {
        if (transform.position - new Vector3(next_Station.transform.position.x, 0.3f, next_Station.transform.position.z) != Vector3.zero)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(next_Station.transform.position.x, 0.3f, next_Station.transform.position.z), Speed * Time.deltaTime);
        }
        Debug.Log(next_Station.transform.position);
    }
}
