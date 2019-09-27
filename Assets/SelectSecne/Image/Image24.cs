using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image24 : MonoBehaviour {
    private int Image24Flag;
    // Start is called before the first frame update
    void Start () {
        Image24Flag = PlayerPrefs.GetInt ("btn24", 0);

        if (Image24Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}