﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Stage1Method : MonoBehaviour {

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void OnClick () { // 必ず public にする

        SceneManager.LoadScene ("Scene1");

    }
}