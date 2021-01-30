using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject ItemPrefab;
    public ItemDatabase database;
    public void OnEnable()
    {
        int i;
        for (i =0; i< 5; i++) {
            Button buttonInPrefab = ItemPrefab.GetComponentInChildren<Button>();
            buttonInPrefab.image.enabled = false;   
        }
    }
}