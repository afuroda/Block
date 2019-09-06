using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabBottomCube2 : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

        for (int i = 0; i < 5; i++) { // CubeプレハブをGameObject型で取得
            int value = Random.Range (7, 10 + 1);
            GameObject obj = (GameObject) Resources.Load ("Block");
            // Cubeプレハブを元に、インスタンスを生成、
            GameObject target = Instantiate (obj, new Vector3 (-4.0f + (i * 2.0f), 0.0f, -10.0f), Quaternion.identity);

            if (value == 7) {
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

    // Update is called once per frame
    void Update () {

    }
}