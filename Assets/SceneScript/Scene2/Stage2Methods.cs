﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage2Methods : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        PlayerPrefs.SetInt ("BTN2", 1);
        PlayerPrefs.Save ();
    }

    // Update is called once per frame
    void Update () {

    }
    public void OnClick () { // 必ず public にする
        SceneManager.LoadScene ("Scene3");
    }
}