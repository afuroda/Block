using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseBtnMethod : MonoBehaviour {

    private Image btnImage;

    public Sprite PauseSprite;

    public Sprite PlaySprite;

    public static bool PauseFlag;

    public Rigidbody PauseRigidbody;

    public Vector3 PauseVelocity;
    // Start is called before the first frame update
    void Start () {

        PauseFlag = false;
        btnImage = GameObject.Find ("Canvas/PauseBtn").GetComponent<Image> ();
    }

    // Update is called once per frame
    void Update () {

    }

    public void changeSprite () { // 必ず public にする

        if (PauseFlag == false) {

            PauseRigidbody = Ball.Egg.GetComponent<Rigidbody> ();
            PauseVelocity = Ball.Egg.GetComponent<Rigidbody> ().velocity;

            PauseRigidbody.velocity = Vector3.zero;

            btnImage.sprite = PlaySprite;
            PauseFlag = true;
        } else if (PauseFlag == true) {

            PauseRigidbody.velocity = PauseVelocity;

            btnImage.sprite = PauseSprite;
            PauseFlag = false;
        }

    }
}