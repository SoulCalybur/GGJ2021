using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Component[] liste;

    void Start()
    {
        liste = gameObject.GetComponents(typeof(BuriedItem));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
