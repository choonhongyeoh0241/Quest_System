using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Quest))]
public class QuestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Quest script = (Quest)target;
        GUIContent statusMarker = new GUIContent("QuestStatus");
        script.arrayIdx = EditorGUILayout.Popup(statusMarker, script.arrayIdx, script.questStatus);
    }
}
