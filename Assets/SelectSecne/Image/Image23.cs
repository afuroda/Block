using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image23 : MonoBehaviour {
    private int Image23Flag;
    // Start is called before the first frame update
    void Start () {
        Image23Flag = PlayerPrefs.GetInt ("btn23", 0);

        if (Image23Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}