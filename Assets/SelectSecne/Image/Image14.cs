using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image14 : MonoBehaviour {
    private int Image14Flag;
    // Start is called before the first frame update
    void Start () {
        Image14Flag = PlayerPrefs.GetInt ("btn14", 0);

        if (Image14Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}