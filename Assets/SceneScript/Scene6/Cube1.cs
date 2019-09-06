using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour {
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
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (46, 125, 50, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "9") {
                this.gameObject.GetComponent<Renderer> ().name = "8";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (56, 142, 60, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "8") {
                this.gameObject.GetComponent<Renderer> ().name = "7";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (67, 160, 71, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "7") {
                this.gameObject.GetComponent<Renderer> ().name = "6";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (76, 175, 80, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "6") {
                this.gameObject.GetComponent<Renderer> ().name = "5";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (102, 187, 106, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "5") {
                this.gameObject.GetComponent<Renderer> ().name = "4";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (129, 199, 132, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "4") {
                this.gameObject.GetComponent<Renderer> ().name = "3";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (165, 214, 167, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "3") {
                this.gameObject.GetComponent<Renderer> ().name = "2";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (200, 230, 201, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "2") {
                this.gameObject.GetComponent<Renderer> ().name = "1";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (232, 245, 233, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "1") {
                Destroy (this.gameObject);
            }
        }
    }
}