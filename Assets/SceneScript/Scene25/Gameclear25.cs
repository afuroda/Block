using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear25 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip soundClear;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("FirstFlag", 25);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        PlayerPrefs.SetInt("btn26", 1);
        PlayerPrefs.Save();
        //ボールが触れたらボールを停止させる
        Ball.Egg.velocity = Vector3.zero;
        audioSource.PlayOneShot(soundClear);
        Common.WinResult = true;
    }
}