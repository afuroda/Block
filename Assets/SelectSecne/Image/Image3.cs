using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image3 : MonoBehaviour {
    private int Image3Flag;
    // Start is called before the first frame update
    void Start () {
        Image3Flag = PlayerPrefs.GetInt ("btn3", 0);

        if (Image3Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}