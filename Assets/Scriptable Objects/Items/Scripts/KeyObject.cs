using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Key Object", menuName = "Inventory System/Items/Key")]
public class KeyObject : ItemObject
{
    private bool openDoor;
    public void Awake()
    {
        type = itemType.Key;
    }
}
