using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image7 : MonoBehaviour {
    private int Image7Flag;
    // Start is called before the first frame update
    void Start () {
        Image7Flag = PlayerPrefs.GetInt ("btn7", 0);

        if (Image7Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}