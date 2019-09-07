using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {
    Rigidbody rg;

    Vector3 rgPosition;

    private Vector3 screenPoint;
    private Vector3 offset;

    void Start () {
        rg = this.GetComponent<Rigidbody> ();
    }

    void OnMouseDown () {
        //カメラから見たオブジェクトの現在位置を画面位置座標に変換
        screenPoint = Camera.main.WorldToScreenPoint (transform.position);

        //取得したscreenPointの値を変数に格納
        float x = Input.mousePosition.x;
        float y = Input.mousePosition.y;

        //オブジェクトの座標からマウス位置(つまりクリックした位置)を引いている。
        //これでオブジェクトの位置とマウスクリックの位置の差が取得できる。
        //ドラッグで移動したときのずれを補正するための計算だと考えれば分かりやすい
        offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (x, y, screenPoint.z));
    }

    void OnMouseDrag () {
        if (PauseBtnMethod.PauseFlag == false) {

            //ドラッグ時のマウス位置を変数に格納
            float x = Input.mousePosition.x;
            float y = Input.mousePosition.y;

            //ドラッグ時のマウス位置をシーン上の3D空間の座標に変換する
            Vector3 currentScreenPoint = new Vector3 (x, y, screenPoint.z);

            //上記にクリックした場所の差を足すことによって、オブジェクトを移動する座標位置を求める
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint (currentScreenPoint) + offset;

            //オブジェクトの位置を変更する
            rg.position = currentPosition;

            if (rg.position.z < -6.1 && rg.position.x > 4.0) {
                rg.position = new Vector3 (3.9f, 0f, -6.0f);
            }
            if (rg.position.z < -6.1 && rg.position.x < -3.9) {
                rg.position = new Vector3 (-3.8f, 0f, -6.0f);
            }
            if (rg.position.z < -6.1) {
                rg.position = new Vector3 (currentPosition.x, 0f, -6.0f);
            }

            if (rg.position.z > -6.1) {
                rg.position = new Vector3 (currentPosition.x, 0f, -6.0f);
            }

            if (rg.position.z > -6.1 && rg.position.x > 4.0) {
                rg.position = new Vector3 (3.9f, 0f, -6.0f);
            }

            if (rg.position.z > -6.1 && rg.position.x < -3.9) {
                rg.position = new Vector3 (-3.8f, 0f, -6.0f);
            }

            if (rg.position.x > 4.0) {
                rg.position = new Vector3 (3.9f, 0f, currentPosition.z);
            }
            if (rg.position.x < -3.9) {
                rg.position = new Vector3 (-3.8f, 0f, currentPosition.z);
            }

        }

    }

}