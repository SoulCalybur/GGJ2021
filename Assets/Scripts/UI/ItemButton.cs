using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{

    public int id = -1;
    private Image btnImage;
    // Start is called before the first frame update
    void Start()
    {
        btnImage = gameObject.GetComponentInChildren<Button>().image;
    }

    public void Found() {
        btnImage.enabled = false;
    }

}
