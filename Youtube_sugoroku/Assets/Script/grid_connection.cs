using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class grid_connection : ScriptableObject
{
    [SerializeField] string Station_name;
    [SerializeField] List<GameObject> Station = new List<GameObject>();
    //[SerializeField] List<GameObject> Arrow = new List<GameObject>();
    [SerializeField] int connection_number;

    public int Connection_Number { get { return connection_number; } set { connection_number = value; } }
    public List<GameObject> station { get { return Station; } set { Station = value; } }
    //public List<GameObject> arrow { get { return Arrow; } set { Arrow = value; } }
    public string station_name { get { return Station_name; } set { Station_name = value; } }
}