using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverBar2 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {
        //ボールが触れたらボールを停止させる
        Ball2.Egg2.velocity = Vector3.zero;

        Common.LoseResult = true;
    }
}