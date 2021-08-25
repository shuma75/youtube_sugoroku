using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(grid_connection))]
public class Connection_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        grid_connection gricone = target as grid_connection;

        gricone.station_name = EditorGUILayout.TextField("駅名", gricone.station_name);
        gricone.Connection_Number = EditorGUILayout.IntField("接続数", gricone.Connection_Number);
        List<GameObject> list = gricone.station;

        int i, len = list.Count;
        for (i = 0; i < len; ++i)
        {
            int num = i + 1;
            EditorGUILayout.LabelField("駅" + num);
            list[i] = EditorGUILayout.ObjectField(list[i], typeof(GameObject), true) as GameObject;
        }
        if (gricone.Connection_Number - list.Count > 0)
        {
            int increase_number = gricone.Connection_Number - list.Count;
            for (int j = 0; j < increase_number; j++) list.Add(null);
        }
        else if (gricone.Connection_Number - list.Count < 0)
        {
            int decrease_number = list.Count - gricone.Connection_Number;
            for (int k = 0; k < decrease_number; k++) list.RemoveAt(len - 1);
        }
    }
}
