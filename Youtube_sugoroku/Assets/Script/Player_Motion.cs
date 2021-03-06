using UnityEngine;

public class Player_Motion : MonoBehaviour
{
    [SerializeField] float Speed = 4;
    [HideInInspector] public GameObject next_Station;
    [HideInInspector] public string next_station_name;
    [HideInInspector] public bool movable = false;
    public Vector3 Next_Station_position;
    private Vector3 previous_station_position;
    roll_dice roll_Dice;

    private void Start()
    {
        next_Station.transform.position = transform.position;
        roll_Dice = GameObject.Find("Dice_Manager").GetComponent<roll_dice>();
    }

    //void Update()
    //{
    //    Debug.Log(roll_Dice.dice_value);
    //    if (roll_Dice.dice_value > 0)
    //    {
    //        next_Station = GameObject.Find(next_station_name);
    //        if (new Vector3(transform.position.x, 0.3f,transform.position.z) - new Vector3(next_Station.transform.position.x, 0.3f, next_Station.transform.position.z) != Vector3.zero)
    //        {
    //            transform.position = Vector3.MoveTowards(transform.position, new Vector3(next_Station.transform.position.x, next_Station.transform.position.y + 0.3f, next_Station.transform.position.z), Speed * Time.deltaTime);
    //        }
    //        Vector3 diff = transform.position - previous_station_position;
    //        previous_station_position = transform.position;

    //        if (diff.magnitude > 0.01f)
    //        {
    //            transform.rotation = Quaternion.LookRotation(diff);
    //        }
    //        roll_Dice.dice_value -= 1;
    //    }
    //}

    public void Train_motion()
    {
        //地下鉄の動き
        transform.position = Vector3.MoveTowards(transform.position, Next_Station_position, Speed * Time.deltaTime);
        //地下鉄の向き
        Vector3 diff = transform.position - previous_station_position;
        previous_station_position = transform.position;

        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }
    }
}
