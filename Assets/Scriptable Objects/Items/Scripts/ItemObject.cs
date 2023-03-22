using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum itemType
{
    Key,
    Default
}
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public itemType type;
    [TextArea(15, 20)]
    public string description;
}
