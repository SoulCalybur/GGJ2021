using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
   

    //Diese Methode soll aufgerufen werden wenn der Hund etwas von der Liste findet. 
    //Tag wird verglichen, und Button auf gr�n gesetzt
    //found == true muss erf�llt sein!
    public void ItemFound(string itemName, bool found)
    {
        if (itemName.Equals("AlarmClock")&& found == true)
        {
            GameObject.FindGameObjectWithTag("AlarmClock").GetComponentInChildren<Button>().image.enabled = false;
        }
        else if (itemName.Equals("Lightsaber") && found == true)
        {
            GameObject.FindGameObjectWithTag("Lightsaber").GetComponentInChildren<Button>().image.enabled = false;
        }
        else if (itemName.Equals("Lightsaber") && found == true)
        {
            GameObject.FindGameObjectWithTag("Lightsaber").GetComponentInChildren<Button>().image.enabled = false;
        }

        else if (itemName.Equals("Lightsaber") && found == true)
        {
            GameObject.FindGameObjectWithTag("Lightsaber").GetComponentInChildren<Button>().image.enabled = false;
        }
        else
        {
            Debug.Log("Findet Tag oder id nicht");
        }
            }
        }