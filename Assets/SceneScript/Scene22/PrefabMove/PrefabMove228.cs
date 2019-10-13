using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMove228 : MonoBehaviour {
    // Start is called before the first frame update
    int MoveFlag;

    GameObject target;
    // Start is called before the first frame update
    void Start () {

        for (int i = 0; i < 15; i++) {
            int value = Random.Range (7, 10 + 1);
            if (i <= 0) {

                // CubeプレハブをGameObject型で取得
                GameObject obj = (GameObject) Resources.Load ("BlueCube");
                // Cubeプレハブを元に、インスタンスを生成、
                target = Instantiate (obj, new Vector3 (-0.5f, 0.0f, 7f), Quaternion.identity);

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

    }

    // Update is called once per frame
    void Update () {

        if (target.transform.position.x >= 0.5 && target.transform.position.z >= 7) {
            MoveFlag = 1;
        } else if (target.transform.position.x >= 0.5 && target.transform.position.z <= 6) {
            MoveFlag = 2;
        } else if (target.transform.position.x <= -0.5 && target.transform.position.z <= 6) {
            MoveFlag = 3;
        } else if (target.transform.position.x <= -0.5 && target.transform.position.z >= 7) {
            MoveFlag = 4;
        }

        if (MoveFlag == 1) {
            target.transform.Translate (0f, 0f, -0.1f);
        } else if (MoveFlag == 2) {
            target.transform.Translate (-0.1f, 0f, 0f);
        } else if (MoveFlag == 3) {
            target.transform.Translate (0f, 0f, 0.1f);
        } else if (MoveFlag == 4) {
            target.transform.Translate (0.1f, 0f, 0f);
        }

    }
}