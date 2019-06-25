﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomPropertyDrawer(typeof(BoolReference))]
public class BoolPropertyDrawer : PropertyDrawer
{
    private string[] options = { "Use Constant", "Use Variable" };
    private int boolVal = 0;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUILayout.BeginHorizontal();
        bool useConstant = property.FindPropertyRelative("useConstant").boolValue = (boolVal == 0);

        EditorGUILayout.PropertyField(useConstant ? property.FindPropertyRelative("constantValue") : property.FindPropertyRelative("boolVariable"), label);
        boolVal = EditorGUILayout.Popup(boolVal, options, GUILayout.Width(15));
        GUILayout.EndHorizontal();
    }
}
