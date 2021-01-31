using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiggingAction : MonoBehaviour
{

    public BuriedItem[] buriedItems;
    private BuriedItem foundItem;
    private List<BuriedItem> foundItems;

    [SerializeField]
    private GameObject uiBar;
    private Slider progressBar;

    private PlayerController controller;

    [SerializeField]
    private GameObject digPrefab;

    private GameObject digHole = null;
    public IEnumerator startDigging() {
        digHole = Instantiate(digPrefab, this.transform.position + this.transform.forward * 1.4f, Quaternion.identity);
        progressBar.value = 0.3f;

        foundItem = findClosestItem();
        if(foundItem != null) {
            foundItem.transform.position = digHole.transform.position + new Vector3(0, -1 + progressBar.value, 0);
        }
        yield break;
    }

    public void digDeeper() {
        increaseValue(0.15f);
    }

    private BuriedItem findClosestItem() {
        BuriedItem closest = null;
        for (int i = 0; i < buriedItems.Length; i++) {
            if (buriedItems[i].found) return null;

            float minDistItem = buriedItems[i].GetComponent<AudioSource>().minDistance;
            Vector3 itemPos = buriedItems[i].transform.position;
            Vector3 playerPos = this.transform.position;
            float distToItem = Vector3.Distance(playerPos, itemPos);
            if(distToItem <= minDistItem) {
                closest = buriedItems[i];
                break;
            }
        }
        return closest;
    }

    void setValue(float val) {
        // val should be [0,1]
        val = Mathf.Clamp(val, 0, 1);

        progressBar.value = val;
        if (progressBar.value >= 0.99999) {
            // send Event "found item"
        }
    }

    void increaseValue(float amount) {
        progressBar.value += amount;
        if(progressBar.value >= 0.99999) {
            controller.isDigging = false;

            foundItem.transform.position = digHole.transform.position + new Vector3(0, 1, 0);
            foundItem.found = true;
            foundItem.GetComponentInChildren<BoxCollider>().enabled = false;
            foundItem.GetComponent<AudioSource>().Stop();
            foundItems.Add(foundItem);
            Debug.Log(foundItems.Count);

            foundItem = null;
        }
    }
    

    void Update()
    {   
        if(controller.isDigging) {
            progressBar.value -= Time.deltaTime * 0.5f;
            digHole.transform.localScale = new Vector3(1f + progressBar.value, 1, 1f + progressBar.value);
            if(foundItem != null) {
                foundItem.transform.position = digHole.transform.position + new Vector3(0, -1 + progressBar.value, 0);
            }
            if(progressBar.value <= 0.00005f) {
                controller.isDigging = false;
            }
        }

        if (foundItems.Count > 0) {
            for (int i = 0; i < foundItems.Count; i++) {
                Debug.Log(foundItems[i]);
                foundItems[i].transform.Rotate(Vector3.up, 0.3f);
            }
        }
    }
    void Start() {
        foundItems = new List<BuriedItem>();

        progressBar = uiBar.GetComponent<Slider>();
        controller = gameObject.GetComponent<PlayerController>();

        buriedItems = Object.FindObjectsOfType<BuriedItem>();

    }
}
