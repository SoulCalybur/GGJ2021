using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{

    public BuriedItem[] buriedItems;
    private ItemButton[] itemButtons;

    private void Start() {
        buriedItems = Object.FindObjectsOfType<BuriedItem>();
        itemButtons = gameObject.GetComponentsInChildren<ItemButton>();
    }
    //Diese Methode soll aufgerufen werden wenn der Hund etwas von der Liste findet. 
    //Tag wird verglichen, und Button auf grün gesetzt
    //found == true muss erfüllt sein!
    public void ItemFound(int itemId)
    {
        for (int i = 0; i < itemButtons.Length; i++) {
            if(itemButtons[i].id == itemId) {
                itemButtons[i].Found();
                break;
            }
        }
    }
}