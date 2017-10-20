using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Timeline;

// Custom InspectorGUI drawed inside timeline clip's properties window
[CustomEditor(typeof(AchievementShot))]
public class AchievementShotEditor : Editor
{
    private void OnEnable()
    {
        if (target != null)
        {
            Debug.Log(target);
        }
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Check check??");
    }
}
