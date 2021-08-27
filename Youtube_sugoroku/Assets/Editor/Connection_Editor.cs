using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//ScriptableObjectの見た目
[CustomEditor(typeof(grid_connection))]
public class Connection_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        grid_connection gricone = target as grid_connection;

        gricone.station_name = EditorGUILayout.TextField("駅名", gricone.station_name);
        gricone.Connection_Number = EditorGUILayout.IntField("接続数", gricone.Connection_Number);
        EditorGUILayout.LabelField("位置");
        gricone.station_position = EditorGUILayout.Vector3Field("",gricone.station_position);
        if (GUILayout.Button("位置調整"))
        {
            GameObject current_station = GameObject.Find(gricone.station_name);
            current_station.transform.position = gricone.station_position;
        }
        List<string> list = gricone.station;
        int i, len = list.Count;
        for (i = 0; i < len; ++i)
        {
            int num = i + 1;
            EditorGUILayout.LabelField("駅番号" + num);
            list[i] = EditorGUILayout.TextField(list[i]);
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
        
        if (GUILayout.Button("保存"))
        {
            EditorUtility.SetDirty(gricone);
            AssetDatabase.SaveAssets();
        }
    }
}
