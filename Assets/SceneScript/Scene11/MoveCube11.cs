using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube11 : MonoBehaviour {

    Rigidbody MoveCube;

    bool MoveFlag;

    // Start is called before the first frame update
    void Start () {
        MoveCube = this.GetComponent<Rigidbody> ();
        MoveFlag = false;
    }

    // Update is called once per frame
    void Update () {

        if (MoveCube.position.x >= 3.8) {
            MoveFlag = true;
        } else if (MoveCube.position.x <= -3.8) {
            MoveFlag = false;
        }

        if (MoveFlag == true) {
            MoveCube.velocity = new Vector3 (-2f, 0f, 0f);
        } else if (MoveFlag == false) {
            MoveCube.velocity = new Vector3 (2f, 0f, 0f);
        }
    }
}