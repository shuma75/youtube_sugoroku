using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] grid_connection station;
    [SerializeField] int Station_Number = 1;
    [SerializeField] float position_magnification = 0.5f;
    [SerializeField] float Arrow_height = 2f;
    Player_Motion Next_Station;

    public grid_connection grid_Connection { get { return station; } set { station = value; } }
    public int station_Number { get { return Station_Number; } set { Station_Number = value; } }
    public float arrow_height { get { return Arrow_height; } set { Arrow_height = value; } }
    public float Position_magnification { get { return position_magnification; } set { position_magnification = value; } }

    private void Start()
    {
        Next_Station = GameObject.Find("train").GetComponent<Player_Motion>();
    }

    public void Click()
    {
        Debug.Log(station.station[Station_Number - 1]);
        Next_Station.next_station_name = station.station[Station_Number - 1];
    }
}
