using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image2 : MonoBehaviour {

    private int Image2Flag;
    // Start is called before the first frame update
    void Start () {
        Image2Flag = PlayerPrefs.GetInt ("btn2", 0);

        if (Image2Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}