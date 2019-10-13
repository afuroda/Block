using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseBtnMethod : MonoBehaviour {

    public static bool PauseFlag;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void OnClick () { // 必ず public にする
        SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
    }

}