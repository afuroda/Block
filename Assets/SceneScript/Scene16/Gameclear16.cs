﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear16 : MonoBehaviour {
    // Start is called before the first frame update
    public AudioClip soundClear;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start () {
        PlayerPrefs.SetInt ("FirstFlag", 16);
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collisionInfo) {

        PlayerPrefs.SetInt ("btn17", 1);
        PlayerPrefs.Save ();
        //ボールが触れたらボールを停止させる
        BallMini.Egg.velocity = Vector3.zero;
        audioSource.PlayOneShot (soundClear);
        Common.WinResult = true;
    }
}