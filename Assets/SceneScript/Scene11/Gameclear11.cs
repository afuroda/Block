using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear11 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {

        PlayerPrefs.SetInt ("btn12", 1);
        PlayerPrefs.Save ();
        //ボールが触れたらボールを停止させる
        BallMini.Egg.velocity = Vector3.zero;

        Common.WinResult = true;
    }
}