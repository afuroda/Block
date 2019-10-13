using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image25 : MonoBehaviour {
    private int Image25Flag;
    // Start is called before the first frame update
    void Start () {
        Image25Flag = PlayerPrefs.GetInt ("btn25", 0);

        if (Image25Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}