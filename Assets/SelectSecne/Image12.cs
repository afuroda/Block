using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image12 : MonoBehaviour {
    private int Image12Flag;
    // Start is called before the first frame update
    void Start () {
        Image12Flag = PlayerPrefs.GetInt ("btn12", 0);

        if (Image12Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}