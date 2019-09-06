using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block5 : MonoBehaviour {
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
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (173, 20, 87, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "9") {
                this.gameObject.GetComponent<Renderer> ().name = "8";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (194, 24, 91, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "8") {
                this.gameObject.GetComponent<Renderer> ().name = "7";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (216, 27, 96, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "7") {
                this.gameObject.GetComponent<Renderer> ().name = "6";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (233, 30, 99, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "6") {
                this.gameObject.GetComponent<Renderer> ().name = "5";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (236, 64, 122, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "5") {
                this.gameObject.GetComponent<Renderer> ().name = "4";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (240, 98, 146, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "4") {
                this.gameObject.GetComponent<Renderer> ().name = "3";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (244, 143, 177, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "3") {
                this.gameObject.GetComponent<Renderer> ().name = "2";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (248, 187, 208, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "2") {
                this.gameObject.GetComponent<Renderer> ().name = "1";
                this.gameObject.GetComponent<Renderer> ().material.color = new Color32 (252, 228, 236, 1);
            } else if (this.gameObject.GetComponent<Renderer> ().name == "1") {
                Destroy (this.gameObject);
            }
        }
    }
}