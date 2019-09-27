using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image18 : MonoBehaviour {
    private int Image18Flag;
    // Start is called before the first frame update
    void Start () {
        Image18Flag = PlayerPrefs.GetInt ("btn18", 0);

        if (Image18Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}