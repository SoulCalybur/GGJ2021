using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuriedItem : MonoBehaviour
{
    
    [SerializeField] public  int id;
    [SerializeField] public  string itemName;
    [SerializeField] string description;
    [SerializeField] bool found;

    [SerializeField] private AudioClip sound;
    //when ausgegraben, ItemData found = true;
    // Start is called before the first frame update
}
