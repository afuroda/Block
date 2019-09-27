using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMini : MonoBehaviour {
    private float speed = 1500.0f;

    public static Rigidbody Egg;

    public float moveForceMultiplier;
    // Start is called before the first frame update
    void Start () {

        Common.BallFlag = false;
        this.GetComponent<Rigidbody> ().AddForce (
            (transform.forward + transform.right) * speed);

        Egg = this.GetComponent<Rigidbody> ();
    }

    void OnCollisionEnter (Collision collisionInfo) {
        this.GetComponent<Rigidbody> ().velocity = this.GetComponent<Rigidbody> ().velocity.normalized * 25;

        if (this.GetComponent<Rigidbody> ().position.x >= 4.6 && collisionInfo.gameObject.CompareTag ("Block1")) {
            this.GetComponent<Rigidbody> ().velocity = new Vector3 (-5f, 0f, -5f);
            Debug.Log ("Ball:" + this.GetComponent<Rigidbody> ().position.x);
        }
        if (this.GetComponent<Rigidbody> ().position.x <= -4.6 && collisionInfo.gameObject.CompareTag ("Block1")) {
            this.GetComponent<Rigidbody> ().velocity = new Vector3 (5f, 0f, 5f);
            Debug.Log ("Ball:" + this.GetComponent<Rigidbody> ().position.x);
        }

        if (collisionInfo.gameObject.CompareTag ("GameClearBar")) {
            Common.BallFlag = true;
        }

        if (collisionInfo.gameObject.CompareTag ("GameOverBar")) {
            Common.BallFlag = true;
        }

    }

    // Update is called once per frame
    void Update () {
        if (Common.BallFlag == true) {
            this.GetComponent<Rigidbody> ().velocity = Vector3.zero;
        }
    }
}