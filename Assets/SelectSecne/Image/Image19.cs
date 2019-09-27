using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image19 : MonoBehaviour {
    private int Image19Flag;
    // Start is called before the first frame update
    void Start () {
        Image19Flag = PlayerPrefs.GetInt ("btn19", 0);

        if (Image19Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}