using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemData", order = 2)]
public class ItemData : ScriptableObject
{
    public string id;
    public string itemName;
    public string description;
    public bool found; 


    public ItemData(string id, string name, string description, bool found) {

    }
}
