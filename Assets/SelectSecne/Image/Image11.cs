using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image11 : MonoBehaviour {
    private int Image11Flag;
    // Start is called before the first frame update
    void Start () {
        Image11Flag = PlayerPrefs.GetInt ("btn11", 0);

        if (Image11Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}