using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image1 : MonoBehaviour {
    private int Image1Flag;
    // Start is called before the first frame update
    void Start () {
        Image1Flag = PlayerPrefs.GetInt ("btn1", 0);
        Debug.Log ("Image1Flag:" + Image1Flag);

        if (Image1Flag == 1) {
            Destroy (this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}