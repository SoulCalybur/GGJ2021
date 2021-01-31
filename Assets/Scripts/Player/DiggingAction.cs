using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiggingAction : MonoBehaviour
{
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
        yield break;
    }

    public void digDeeper() {
        increaseValue(0.15f);
        Debug.Log("Digging deeper!! to:" + progressBar.value);
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
    }
    // Start is called before the first frame update
    void Start()
    {
        progressBar = uiBar.GetComponent<Slider>();
        controller = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(controller.isDigging) {
            progressBar.value -= Time.deltaTime * 0.5f;
            digHole.transform.localScale = new Vector3(1f + progressBar.value, 1, 1f + progressBar.value);
            if(progressBar.value <= 0.00005f) {
                controller.isDigging = false;
            }
        }
    }
}
