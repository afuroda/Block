using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image4 : MonoBehaviour {
    private int Image4Flag;
    // Start is called before the first frame update
    void Start () {
        Image4Flag = PlayerPrefs.GetInt ("btn4", 0);

        if (Image4Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}