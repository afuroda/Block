using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image22 : MonoBehaviour {
    private int Image22Flag;
    // Start is called before the first frame update
    void Start () {
        Image22Flag = PlayerPrefs.GetInt ("btn22", 0);

        if (Image22Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}