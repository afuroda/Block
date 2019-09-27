using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear10 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        PlayerPrefs.SetInt ("FirstFlag", 10);
    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {

        PlayerPrefs.SetInt ("btn11", 1);
        PlayerPrefs.Save ();
        //ボールが触れたらボールを停止させる
        Ball.Egg.velocity = Vector3.zero;

        Common.WinResult = true;
    }
}