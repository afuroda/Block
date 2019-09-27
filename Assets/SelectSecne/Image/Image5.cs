using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image5 : MonoBehaviour {
    private int Image5Flag;
    // Start is called before the first frame update
    void Start () {
        Image5Flag = PlayerPrefs.GetInt ("btn5", 0);

        if (Image5Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}