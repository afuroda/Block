using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image20 : MonoBehaviour {
    private int Image20Flag;
    // Start is called before the first frame update
    void Start () {
        Image20Flag = PlayerPrefs.GetInt ("btn20", 0);

        if (Image20Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}