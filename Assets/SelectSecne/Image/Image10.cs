using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image10 : MonoBehaviour {
    private int Image10Flag;
    // Start is called before the first frame update
    void Start () {
        Image10Flag = PlayerPrefs.GetInt ("btn10", 0);

        if (Image10Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}