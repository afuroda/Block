using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image15 : MonoBehaviour {
    private int Image15Flag;
    // Start is called before the first frame update
    void Start () {
        Image15Flag = PlayerPrefs.GetInt ("btn15", 0);

        if (Image15Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}