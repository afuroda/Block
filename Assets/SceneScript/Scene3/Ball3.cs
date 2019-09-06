using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3 : MonoBehaviour {
    private float speed = 2000.0f;

    public static Rigidbody Egg3;

    public float moveForceMultiplier;
    // Start is called before the first frame update
    void Start () {
        this.GetComponent<Rigidbody> ().AddForce (
            (transform.forward + transform.right) * speed);

        Egg3 = this.GetComponent<Rigidbody> ();
    }

    void OnCollisionEnter (Collision collisionInfo) {
        this.GetComponent<Rigidbody> ().velocity = this.GetComponent<Rigidbody> ().velocity.normalized * 30;

        if (this.GetComponent<Rigidbody> ().position.x == 4.5) {
            this.GetComponent<Rigidbody> ().velocity = new Vector3 (-5f, 0f, -5f);
        }
        if (this.GetComponent<Rigidbody> ().position.x == -4.5) {
            this.GetComponent<Rigidbody> ().velocity = new Vector3 (5f, 0f, 5f);
        }
    }

    // Update is called once per frame
    void Update () { }
}