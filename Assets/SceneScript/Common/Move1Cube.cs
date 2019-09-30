using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1Cube : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collision) {
        //衝突判定
        if (collision.gameObject.tag == "Ball") {

            if (this.gameObject.GetComponent<Renderer> ().name == "10") {
                this.gameObject.GetComponent<Renderer> ().name = "9";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (21, 101, 192, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "9") {
                this.gameObject.GetComponent<Renderer> ().name = "8";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (25, 118, 210, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "8") {
                this.gameObject.GetComponent<Renderer> ().name = "7";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (30, 136, 229, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "7") {
                this.gameObject.GetComponent<Renderer> ().name = "6";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (33, 150, 243, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "6") {
                this.gameObject.GetComponent<Renderer> ().name = "5";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (66, 165, 245, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "5") {
                this.gameObject.GetComponent<Renderer> ().name = "4";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (100, 181, 246, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "4") {
                this.gameObject.GetComponent<Renderer> ().name = "3";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (144, 202, 249, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "3") {
                this.gameObject.GetComponent<Renderer> ().name = "2";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (187, 222, 251, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "2") {
                this.gameObject.GetComponent<Renderer> ().name = "1";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (227, 242, 253, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "1") {
                Destroy (this.gameObject);
            }
        }
    }
}