using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Arrow))]
public class Arrow_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        Arrow arrow = target as Arrow;

        EditorGUILayout.LabelField("現在の駅");
        arrow.grid_Connection = (grid_connection)EditorGUILayout.ObjectField(arrow.grid_Connection, typeof(ScriptableObject), true);
        arrow.station_Number = EditorGUILayout.IntField("行先の駅番号", arrow.station_Number);
        if (GUILayout.Button("位置調整"))
        {
            GameObject Station = GameObject.Find(arrow.grid_Connection.station[arrow.station_Number - 1]);
            Vector2 Arrow_position = new Vector2(Station.transform.position.x - arrow.transform.parent.transform.position.x,
                Station.transform.position.z - arrow.transform.parent.transform.position.z).normalized * 2;
            arrow.transform.position = arrow.transform.parent.transform.position + new Vector3(Arrow_position.x,1.5f,Arrow_position.y);
            arrow.transform.LookAt(new Vector3(Station.transform.position.x, 1.5f, Station.transform.position.z));
            Debug.Log(Arrow_position);
        }
    }
}
