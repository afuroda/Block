using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image13 : MonoBehaviour {
    private int Image13Flag;
    // Start is called before the first frame update
    void Start () {
        Image13Flag = PlayerPrefs.GetInt ("btn13", 0);

        if (Image13Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}