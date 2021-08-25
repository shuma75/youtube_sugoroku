using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] grid_connection station;
    [SerializeField] int Station_Number = 1;

    public grid_connection grid_Connection { get { return station; } set { station = value; } }
    public int station_Number { get { return Station_Number; } set { Station_Number = value; } }

    public void Click()
    {
        Debug.Log(station.station[Station_Number - 1]);
    }
}
