using System.Collections.Generic;
using UnityEditor;

using UnityEngine;

[CustomPropertyDrawer(typeof(ListPopupAttribute))]
public class ListPopupDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var attr = (ListPopupAttribute)attribute;

        if (attr.Type.GetField(attr.Name) == null) return;

        if (attr.Type.GetField(attr.Name).GetValue(attr.Type) is not List<string> speakerNames || speakerNames.Count == 0)
        {
            property.stringValue = "No objects available";
            return;
        }

        int idx = Mathf.Max(0, speakerNames.IndexOf(property.stringValue));
        idx = EditorGUI.Popup(position, ObjectNames.NicifyVariableName(property.name), idx, speakerNames.ToArray());
        property.stringValue = speakerNames[idx];
    }
}