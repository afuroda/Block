using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image28 : MonoBehaviour {
    private int Image28Flag;
    // Start is called before the first frame update
    void Start () {
        Image28Flag = PlayerPrefs.GetInt ("btn28", 0);

        if (Image28Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}