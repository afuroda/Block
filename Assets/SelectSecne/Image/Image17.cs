using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image17 : MonoBehaviour {
    private int Image17Flag;
    // Start is called before the first frame update
    void Start () {
        Image17Flag = PlayerPrefs.GetInt ("btn17", 0);

        if (Image17Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}