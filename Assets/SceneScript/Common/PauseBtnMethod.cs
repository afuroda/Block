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
    public Rigidbody PauseRigidbodyMini;
    public Rigidbody PauseRigidbodyMini2;

    public Vector3 PauseVelocity;
    public Vector3 PauseVelocityMini;
    public Vector3 PauseVelocityMini2;

    public int SplitFlag;
    // Start is called before the first frame update
    void Start () {

        PauseFlag = false;
        btnImage = GameObject.Find ("Canvas/PauseBtn").GetComponent<Image> ();
        SplitFlag = PlayerPrefs.GetInt ("FirstFlag", 0);

    }

    // Update is called once per frame
    void Update () {

    }

    public void changeSprite () { // 必ず public にする

        if (PauseFlag == false) {

            if (0 <= SplitFlag && SplitFlag <= 6 || SplitFlag == 10 || SplitFlag == 13 || SplitFlag == 15) {
                PauseRigidbody = Ball.Egg.GetComponent<Rigidbody> ();
                PauseVelocity = Ball.Egg.GetComponent<Rigidbody> ().velocity;
                PauseRigidbody.velocity = Vector3.zero;
            } else if (SplitFlag == 7 || SplitFlag == 9 || 11 == SplitFlag || SplitFlag == 12 || SplitFlag == 14 || SplitFlag == 16) {
                PauseRigidbodyMini = BallMini.Egg.GetComponent<Rigidbody> ();
                PauseVelocityMini = BallMini.Egg.GetComponent<Rigidbody> ().velocity;
                PauseRigidbodyMini.velocity = Vector3.zero;
            } else if (SplitFlag == 8) {
                PauseRigidbodyMini = BallMini.Egg.GetComponent<Rigidbody> ();
                PauseVelocityMini = BallMini.Egg.GetComponent<Rigidbody> ().velocity;
                PauseRigidbodyMini.velocity = Vector3.zero;

                PauseRigidbodyMini2 = BallMini2.Egg.GetComponent<Rigidbody> ();
                PauseVelocityMini2 = BallMini2.Egg.GetComponent<Rigidbody> ().velocity;
                PauseRigidbodyMini2.velocity = Vector3.zero;
            }

            btnImage.sprite = PlaySprite;
            PauseFlag = true;
        } else if (PauseFlag == true) {

            if (0 <= SplitFlag && SplitFlag <= 6 || SplitFlag == 10 || SplitFlag == 13 || SplitFlag == 15) {
                PauseRigidbody.velocity = PauseVelocity;
            } else if (SplitFlag == 7 || SplitFlag == 9 || 11 == SplitFlag || SplitFlag == 12 || SplitFlag == 14 || SplitFlag == 16) {
                PauseRigidbodyMini.velocity = PauseVelocityMini;
            } else if (SplitFlag == 8) {
                PauseRigidbodyMini.velocity = PauseVelocityMini;
                PauseRigidbodyMini2.velocity = PauseVelocityMini2;
            }

            btnImage.sprite = PauseSprite;
            PauseFlag = false;
        }

    }
}