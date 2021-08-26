using UnityEngine;

public class Player_Motion : MonoBehaviour
{
    [SerializeField] float Speed = 4;
    [HideInInspector] public GameObject next_Station;
    [HideInInspector] public string next_station_name;
    [HideInInspector] public bool movable = false;

    private void Start()
    {
        next_Station.transform.position = transform.position;
    }

    void Update()
    {
        if (movable == true)
        {
            next_Station = GameObject.Find(next_station_name);
            if (new Vector3(transform.position.x, 0.3f,transform.position.z) - new Vector3(next_Station.transform.position.x, 0.3f, next_Station.transform.position.z) != Vector3.zero)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(next_Station.transform.position.x, 0.3f, next_Station.transform.position.z), Speed * Time.deltaTime);
            }
            
        }
    }
}
