using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear8 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        PlayerPrefs.SetInt ("FirstFlag", 8);
    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {

        PlayerPrefs.SetInt ("btn9", 1);
        PlayerPrefs.Save ();
        //ボールが触れたらボールを停止させる
        BallMini.Egg.velocity = Vector3.zero;

        Common.WinResult = true;

    }
}