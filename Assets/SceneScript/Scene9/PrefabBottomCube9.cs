﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabBottomCube9 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

        for (int i = 0; i < 10; i++) { // CubeプレハブをGameObject型で取得
            int value = Random.Range (7, 10 + 1);
            GameObject obj = (GameObject) Resources.Load ("1Cube");
            // Cubeプレハブを元に、インスタンスを生成、
            GameObject target = Instantiate (obj, new Vector3 (-4.5f + (i * 1.0f), 0.0f, -10.0f), Quaternion.identity);
            if (value == 0) {
                Destroy (target);
            } else if (value == 1) {
                target.GetComponent<Renderer> ().material.color = new Color32 (232, 245, 233, 1);
                target.name = value.ToString ();
            } else if (value == 2) {
                target.GetComponent<Renderer> ().material.color = new Color32 (200, 230, 201, 1);
                target.name = value.ToString ();
            } else if (value == 3) {
                target.GetComponent<Renderer> ().material.color = new Color32 (165, 214, 167, 1);
                target.name = value.ToString ();
            } else if (value == 4) {
                target.GetComponent<Renderer> ().material.color = new Color32 (129, 199, 132, 1);
                target.name = value.ToString ();
            } else if (value == 5) {
                target.GetComponent<Renderer> ().material.color = new Color32 (102, 187, 106, 1);
                target.name = value.ToString ();
            } else if (value == 6) {
                target.GetComponent<Renderer> ().material.color = new Color32 (76, 175, 80, 1);
                target.name = value.ToString ();
            } else if (value == 7) {
                target.GetComponent<Renderer> ().material.color = new Color32 (67, 160, 71, 1);
                target.name = value.ToString ();
            } else if (value == 8) {
                target.GetComponent<Renderer> ().material.color = new Color32 (56, 142, 60, 1);
                target.name = value.ToString ();
            } else if (value == 9) {
                target.GetComponent<Renderer> ().material.color = new Color32 (46, 125, 50, 1);
                target.name = value.ToString ();
            } else if (value == 10) {
                target.GetComponent<Renderer> ().material.color = new Color32 (27, 94, 32, 1);
                target.name = value.ToString ();
            }
        }
    }

    // Update is called once per frame
    void Update () {

    }
}