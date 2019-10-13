using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image27 : MonoBehaviour {
    private int Image27Flag;
    // Start is called before the first frame update
    void Start () {
        Image27Flag = PlayerPrefs.GetInt ("btn27", 0);

        if (Image27Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}