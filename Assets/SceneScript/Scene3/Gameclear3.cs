using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear3 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        PlayerPrefs.SetInt ("FirstFlag", 3);
    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {

        PlayerPrefs.SetInt ("btn4", 1);
        PlayerPrefs.Save ();
        //ボールが触れたらボールを停止させる
        Ball.Egg.velocity = Vector3.zero;

        Common.WinResult = true;
    }
}