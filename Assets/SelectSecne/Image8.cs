using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image8 : MonoBehaviour {
    private int Image8Flag;
    // Start is called before the first frame update
    void Start () {
        Image8Flag = PlayerPrefs.GetInt ("btn8", 0);

        if (Image8Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}