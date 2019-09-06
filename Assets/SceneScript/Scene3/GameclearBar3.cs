using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameclearBar3 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {
        //ボールが触れたらボールを停止させる
        Ball3.Egg3.velocity = Vector3.zero;

        Common.WinResult = true;
    }
}