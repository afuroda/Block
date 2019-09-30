using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabBlock14 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

        for (int i = 0; i < 15; i++) {
            int value = Random.Range (3, 5 + 1);
            if (i <= 4) {

                // CubeプレハブをGameObject型で取得
                GameObject obj = (GameObject) Resources.Load ("Block");
                // Cubeプレハブを元に、インスタンスを生成、
                GameObject target = Instantiate (obj, new Vector3 (-4.0f + (i * 2.0f), 0.0f, 10.0f), Quaternion.identity);

                if (value == 0) {
                    Destroy (target);
                } else if (value == 1) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (252, 228, 236, 1);
                    target.name = value.ToString ();
                } else if (value == 2) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (248, 187, 208, 1);
                    target.name = value.ToString ();
                } else if (value == 3) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (244, 143, 177, 1);
                    target.name = value.ToString ();
                } else if (value == 4) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (240, 98, 146, 1);
                    target.name = value.ToString ();
                } else if (value == 5) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (236, 64, 122, 1);
                    target.name = value.ToString ();
                } else if (value == 6) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (233, 30, 99, 1);
                    target.name = value.ToString ();
                } else if (value == 7) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (216, 27, 96, 1);
                    target.name = value.ToString ();
                } else if (value == 8) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (194, 24, 91, 1);
                    target.name = value.ToString ();
                } else if (value == 9) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (173, 20, 87, 1);
                    target.name = value.ToString ();
                } else if (value == 10) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (136, 14, 79, 1);
                    target.name = value.ToString ();
                }

            } else if (i >= 5 && i <= 9) {
                value = 0;
                // CubeプレハブをGameObject型で取得
                GameObject obj = (GameObject) Resources.Load ("Block");
                // Cubeプレハブを元に、インスタンスを生成、
                GameObject target = Instantiate (obj, new Vector3 (-4.0f + ((i - 5) * 2.0f), 0.0f, 9.0f), Quaternion.identity);

                if (value == 0) {
                    Destroy (target);
                } else if (value == 1) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (252, 228, 236, 1);
                    target.name = value.ToString ();
                } else if (value == 2) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (248, 187, 208, 1);
                    target.name = value.ToString ();
                } else if (value == 3) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (244, 143, 177, 1);
                    target.name = value.ToString ();
                } else if (value == 4) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (240, 98, 146, 1);
                    target.name = value.ToString ();
                } else if (value == 5) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (236, 64, 122, 1);
                    target.name = value.ToString ();
                } else if (value == 6) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (233, 30, 99, 1);
                    target.name = value.ToString ();
                } else if (value == 7) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (216, 27, 96, 1);
                    target.name = value.ToString ();
                } else if (value == 8) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (194, 24, 91, 1);
                    target.name = value.ToString ();
                } else if (value == 9) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (173, 20, 87, 1);
                    target.name = value.ToString ();
                } else if (value == 10) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (136, 14, 79, 1);
                    target.name = value.ToString ();
                }

            } else if (i >= 10) {
                value = 0;
                // CubeプレハブをGameObject型で取得
                GameObject obj = (GameObject) Resources.Load ("Block");
                // Cubeプレハブを元に、インスタンスを生成、
                GameObject target = Instantiate (obj, new Vector3 (-4.0f + ((i - 10) * 2.0f), 0.0f, 8.0f), Quaternion.identity);

                if (value == 0) {
                    Destroy (target);
                } else if (value == 1) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (252, 228, 236, 1);
                    target.name = value.ToString ();
                } else if (value == 2) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (248, 187, 208, 1);
                    target.name = value.ToString ();
                } else if (value == 3) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (244, 143, 177, 1);
                    target.name = value.ToString ();
                } else if (value == 4) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (240, 98, 146, 1);
                    target.name = value.ToString ();
                } else if (value == 5) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (236, 64, 122, 1);
                    target.name = value.ToString ();
                } else if (value == 6) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (233, 30, 99, 1);
                    target.name = value.ToString ();
                } else if (value == 7) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (216, 27, 96, 1);
                    target.name = value.ToString ();
                } else if (value == 8) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (194, 24, 91, 1);
                    target.name = value.ToString ();
                } else if (value == 9) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (173, 20, 87, 1);
                    target.name = value.ToString ();
                } else if (value == 10) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (136, 14, 79, 1);
                    target.name = value.ToString ();
                }

            }
        }
    }

    // Update is called once per frame
    void Update () {

    }
}