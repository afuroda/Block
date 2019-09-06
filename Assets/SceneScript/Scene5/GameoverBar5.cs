using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverBar5 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {
        //ボールが触れたらボールを停止させる
        Ball5.Egg5.velocity = Vector3.zero;

        Common.LoseResult = true;
    }
}