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
        } else if (FirstFlag == 15) {
            SceneManager.LoadScene ("Scene15");
        } else if (FirstFlag == 16) {
            SceneManager.LoadScene ("Scene16");
        } else if (FirstFlag == 17) {
            SceneManager.LoadScene ("Scene17");
        } else if (FirstFlag == 18) {
            SceneManager.LoadScene ("Scene18");
        } else if (FirstFlag == 19) {
            SceneManager.LoadScene ("Scene19");
        } else if (FirstFlag == 20) {
            SceneManager.LoadScene ("Scene20");
        } else if (FirstFlag == 21) {
            SceneManager.LoadScene ("Scene21");
        } else if (FirstFlag == 22) {
            SceneManager.LoadScene ("Scene22");
        } else if (FirstFlag == 23) {
            SceneManager.LoadScene ("Scene23");
        } else if (FirstFlag == 24) {
            SceneManager.LoadScene ("Scene24");
        } else if (FirstFlag == 25) {
            SceneManager.LoadScene ("Scene25");
        } else if (FirstFlag == 26) {
            SceneManager.LoadScene ("Scene26");
        } else if (FirstFlag == 27) {
            SceneManager.LoadScene ("Scene27");
        } else if (FirstFlag == 28) {
            SceneManager.LoadScene ("Scene28");
        }
    }
}