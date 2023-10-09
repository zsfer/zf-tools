using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
public class ListPopupAttribute : PropertyAttribute
{
    public Type Type;
    public string Name;
    public ListPopupAttribute(Type type, string name)
    {
        Type = type;
        Name = name;
    }
}