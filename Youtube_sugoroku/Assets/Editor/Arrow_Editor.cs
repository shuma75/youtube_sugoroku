﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Arrow))]
public class Arrow_Editor : Editor
{
    [SerializeField] float position_magnification = 0.2f;
    public override void OnInspectorGUI()
    {
        Arrow arrow = target as Arrow;

        EditorGUILayout.LabelField("現在の駅");
        arrow.grid_Connection = (grid_connection)EditorGUILayout.ObjectField(arrow.grid_Connection, typeof(ScriptableObject), true);
        arrow.station_Number = EditorGUILayout.IntField("行先の駅番号", arrow.station_Number);
        if (GUILayout.Button("位置調整"))
        {
            Vector2 Arrow_position = new Vector2(arrow.grid_Connection.station[arrow.station_Number - 1].transform.position.x - arrow.transform.parent.transform.position.x,
                arrow.grid_Connection.station[arrow.station_Number - 1].transform.position.z - arrow.transform.parent.transform.position.z).normalized;
            arrow.transform.position = arrow.transform.parent.transform.position + new Vector3(Arrow_position.x,1,Arrow_position.y);
            arrow.transform.LookAt(new Vector3(arrow.grid_Connection.station[arrow.station_Number - 1].transform.position.x, 1, arrow.grid_Connection.station[arrow.station_Number - 1].transform.position.z));
            Debug.Log(Arrow_position);
        }
    }
}