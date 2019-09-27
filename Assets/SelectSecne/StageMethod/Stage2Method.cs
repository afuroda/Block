using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Stage2Method : MonoBehaviour {
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
    public void OnClick () { // 必ず public にする
        SceneManager.LoadScene ("Scene2");
    }
}