using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{

    public BuriedItem[] buriedItems;

    private void Start() {
        buriedItems = Object.FindObjectsOfType<BuriedItem>();
    }
    //Diese Methode soll aufgerufen werden wenn der Hund etwas von der Liste findet. 
    //Tag wird verglichen, und Button auf grün gesetzt
    //found == true muss erfüllt sein!
    public void ItemFound(string itemName, bool found)
    {
        if (itemName.Equals("AlarmClock"))
        {
            GameObject.FindGameObjectWithTag("AlarmClock").GetComponentInChildren<Button>().image.enabled = false;
        }
        else if (itemName.Equals("Lightsaber") )
        {
            GameObject.FindGameObjectWithTag("Lightsaber").GetComponentInChildren<Button>().image.enabled = false;
        }
        else if (itemName.Equals("Lightsaber") )
        {
            GameObject.FindGameObjectWithTag("Lightsaber").GetComponentInChildren<Button>().image.enabled = false;
        }

        else if (itemName.Equals("Lightsaber") )
        {
            GameObject.FindGameObjectWithTag("Lightsaber").GetComponentInChildren<Button>().image.enabled = false;
        }
        else
        {
            Debug.Log("Findet Tag oder id nicht");
        }
            }
        }