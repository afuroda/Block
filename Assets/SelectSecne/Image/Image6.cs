using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image6 : MonoBehaviour {
    private int Image6Flag;
    // Start is called before the first frame update
    void Start () {
        Image6Flag = PlayerPrefs.GetInt ("btn6", 0);

        if (Image6Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}