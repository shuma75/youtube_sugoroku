using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu]

public class grid_connection : ScriptableObject
{
    [SerializeField] string Station_name;
    [SerializeField] List<string> Station = new List<string>();
    [SerializeField] int connection_number;
    [SerializeField] Vector3 Station_position;
    

    public int Connection_Number { get { return connection_number; } set { connection_number = value; } }
    public List<string> station { get { return Station; } set { Station = value; } }
    public string station_name { get { return Station_name; } set { Station_name = value; } }
    public Vector3 station_position { get { return Station_position; } set { Station_position = value; } }
}