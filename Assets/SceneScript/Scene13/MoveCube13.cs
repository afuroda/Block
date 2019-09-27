using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube13 : MonoBehaviour {
    // Start is called before the first frame update
    Rigidbody MoveCube;

    bool MoveFlag;

    // Start is called before the first frame update
    void Start () {
        MoveCube = this.GetComponent<Rigidbody> ();
        MoveFlag = false;
    }

    // Update is called once per frame
    void Update () {

        if (MoveCube.position.x >= 3) {
            MoveFlag = true;
        } else if (MoveCube.position.x <= -3) {
            MoveFlag = false;
        }

        if (MoveFlag == true) {
            MoveCube.velocity = new Vector3 (-2f, 0f, 0f);
        } else if (MoveFlag == false) {
            MoveCube.velocity = new Vector3 (2f, 0f, 0f);
        }
    }
}