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
        for (i =0; i< 4; i++) {
            Button buttonInPrefab = ItemPrefab.GetComponentInChildren<Button>();
            buttonInPrefab.image.enabled = false;
        }
    }


    //Diese Methode soll aufgerufen werden wenn der Hund etwas von der Liste findet. 
    //Tag wird verglichen, und Button auf grün gesetzt
    public void ItemFound()
    {
        Button buttonInPrefab = ItemPrefab.GetComponentInChildren<Button>();
        if (buttonInPrefab.GetComponentInChildren<Button>().CompareTag("ButtonLightsaber")){
            buttonInPrefab.image.enabled = true;
        }
        else if (buttonInPrefab.GetComponentInChildren<Button>().CompareTag("ButtonRing"))
        {
            buttonInPrefab.image.enabled = true;
        }
        else if (buttonInPrefab.GetComponentInChildren<Button>().CompareTag("ButtonZombie"))
        {
            buttonInPrefab.image.enabled = true;
        }
        else if (buttonInPrefab.GetComponentInChildren<Button>().CompareTag("ButtonAlarmClock"))
        {
            buttonInPrefab.image.enabled = true;
        }
        else
        {
            Debug.Log("Findet Tag nicht");
        }
    }
}