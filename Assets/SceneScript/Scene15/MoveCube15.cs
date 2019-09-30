using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube15 : MonoBehaviour {
    // Start is called before the first frame update
    Rigidbody MoveCube;

    bool MoveFlag;

    // Start is called before the first frame update
    void Start () {
        MoveCube = this.GetComponent<Rigidbody> ();
        MoveFlag = false;
        MoveCube.velocity = new Vector3 (0f, 0f, -3f);
    }

    // Update is called once per frame
    void Update () {

        if (MoveCube.position.z >= 4) {
            MoveFlag = true;
        } else if (MoveCube.position.z <= -1) {
            MoveFlag = false;
        }

        if (MoveFlag == true) {
            MoveCube.velocity = new Vector3 (0f, 0f, -3f);
        } else if (MoveFlag == false) {
            MoveCube.velocity = new Vector3 (0f, 0f, 3f);
        }
    }
}