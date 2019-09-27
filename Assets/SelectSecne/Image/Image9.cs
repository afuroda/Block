using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image9 : MonoBehaviour {
    private int Image9Flag;
    // Start is called before the first frame update
    void Start () {
        Image9Flag = PlayerPrefs.GetInt ("btn9", 0);

        if (Image9Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}