using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image21 : MonoBehaviour {
    private int Image21Flag;
    // Start is called before the first frame update
    void Start () {
        Image21Flag = PlayerPrefs.GetInt ("btn21", 0);

        if (Image21Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}