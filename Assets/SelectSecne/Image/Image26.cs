using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image26 : MonoBehaviour {
    private int Image26Flag;
    // Start is called before the first frame update
    void Start () {
        Image26Flag = PlayerPrefs.GetInt ("btn26", 0);

        if (Image26Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}