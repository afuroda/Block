using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMove253 : MonoBehaviour {
    // Start is called before the first frame update
    bool MoveFlag;

    GameObject target;
    // Start is called before the first frame update
    void Start () {

        for (int i = 0; i < 15; i++) {
            int value = Random.Range (7, 10 + 1);
            if (i <= 0) {

                // CubeプレハブをGameObject型で取得
                GameObject obj = (GameObject) Resources.Load ("BlueCube");
                // Cubeプレハブを元に、インスタンスを生成、
                target = Instantiate (obj, new Vector3 (-2.5f, 0.0f, 8.5f), Quaternion.identity);

                if (value == 0) {
                    Destroy (target);
                } else if (value == 1) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (227, 242, 253, 1);
                    target.name = value.ToString ();
                } else if (value == 2) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (187, 222, 251, 1);
                    target.name = value.ToString ();
                } else if (value == 3) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (144, 202, 249, 1);
                    target.name = value.ToString ();
                } else if (value == 4) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (100, 181, 246, 1);
                    target.name = value.ToString ();
                } else if (value == 5) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (66, 165, 245, 1);
                    target.name = value.ToString ();
                } else if (value == 6) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (33, 150, 243, 1);
                    target.name = value.ToString ();
                } else if (value == 7) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (30, 136, 229, 1);
                    target.name = value.ToString ();
                } else if (value == 8) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (25, 118, 210, 1);
                    target.name = value.ToString ();
                } else if (value == 9) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (21, 101, 192, 1);
                    target.name = value.ToString ();
                } else if (value == 10) {
                    target.GetComponent<Renderer> ().material.color = new Color32 (13, 71, 161, 1);
                    target.name = value.ToString ();
                }
            }

        }

        MoveFlag = false;
        target.transform.Translate (0f, 0f, -0.05f);
    }

    // Update is called once per frame
    void Update () {
        if (target.transform.position.z >= 9.5) {
            MoveFlag = true;
        } else if (target.transform.position.z <= 8.5) {
            MoveFlag = false;
        }

        if (MoveFlag == true) {
            target.transform.Translate (0f, 0f, -0.05f);
        } else if (MoveFlag == false) {
            target.transform.Translate (0f, 0f, 0.05f);
        }
    }
}