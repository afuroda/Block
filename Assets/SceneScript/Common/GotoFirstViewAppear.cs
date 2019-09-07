using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoFirstViewAppear : MonoBehaviour {

    public static GameObject GoToFirstView;
    // Start is called before the first frame update
    void Start () {
        GoToFirstView = this.gameObject;
        GoToFirstView.SetActive (false);
    }

    // Update is called once per frame
    void Update () {

    }
}