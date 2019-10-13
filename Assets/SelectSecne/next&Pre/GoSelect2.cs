﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoSelect2 : MonoBehaviour {

    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start () {
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {

    }

    public void OnClick () { // 必ず public にする
        audioSource.PlayOneShot (sound1);
        SceneManager.LoadScene ("StageSelect2");
    }
}