using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
    private int FirstFlag;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void OnClick () { // 必ず public にする
        FirstFlag = PlayerPrefs.GetInt ("FirstFlag", 1);

        Debug.Log (FirstFlag);

        if (FirstFlag == 1) {
            SceneManager.LoadScene ("Scene1");
        } else if (FirstFlag == 2) {
            SceneManager.LoadScene ("Scene2");
        } else if (FirstFlag == 3) {
            SceneManager.LoadScene ("Scene3");
        } else if (FirstFlag == 4) {
            SceneManager.LoadScene ("Scene4");
        } else if (FirstFlag == 5) {
            SceneManager.LoadScene ("Scene5");
        } else if (FirstFlag == 6) {
            SceneManager.LoadScene ("Scene6");
        } else if (FirstFlag == 7) {
            SceneManager.LoadScene ("Scene7");
        } else if (FirstFlag == 8) {
            SceneManager.LoadScene ("Scene8");
        } else if (FirstFlag == 9) {
            SceneManager.LoadScene ("Scene9");
        } else if (FirstFlag == 10) {
            SceneManager.LoadScene ("Scene10");
        } else if (FirstFlag == 11) {
            SceneManager.LoadScene ("Scene11");
        } else if (FirstFlag == 12) {
            SceneManager.LoadScene ("Scene12");
        } else if (FirstFlag == 13) {
            SceneManager.LoadScene ("Scene13");
        } else if (FirstFlag == 14) {
            SceneManager.LoadScene ("Scene14");
        }
    }
}