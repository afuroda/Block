﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage3Methods : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        PlayerPrefs.SetInt ("BTN3", 1);
        PlayerPrefs.Save ();
    }

    // Update is called once per frame
    void Update () {

    }

    public void OnClick () { // 必ず public にする
        SceneManager.LoadScene ("Scene4");
    }
}