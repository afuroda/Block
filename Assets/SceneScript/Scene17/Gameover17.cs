using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover17 : MonoBehaviour {
    // Start is called before the first frame update
    public AudioClip soundOver;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start () {
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {
        //ボールが触れたらボールを停止させる
        BallMini.Egg.velocity = Vector3.zero;
        audioSource.PlayOneShot (soundOver);
        Common.LoseResult = true;
    }
}