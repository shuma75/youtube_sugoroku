using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] grid_connection station;
    [SerializeField] int Station_Number = 1;
    Player_Motion Next_Station;

    public grid_connection grid_Connection { get { return station; } set { station = value; } }
    public int station_Number { get { return Station_Number; } set { Station_Number = value; } }

    private void Start()
    {
        Next_Station = GameObject.Find("train").GetComponent<Player_Motion>();
    }

    public void Click()
    {
        Next_Station.movable = true;
        Debug.Log(station.station[Station_Number - 1]);
        Next_Station.next_station_name = station.station[Station_Number - 1];
    }
}
