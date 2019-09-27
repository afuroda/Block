using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image16 : MonoBehaviour {
    private int Image16Flag;
    // Start is called before the first frame update
    void Start () {
        Image16Flag = PlayerPrefs.GetInt ("btn16", 0);

        if (Image16Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}