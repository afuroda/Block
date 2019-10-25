using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmScript : MonoBehaviour {
    // Start is called before the first frame update

    AudioSource audioSource;
    void Start () {
        SceneManager.activeSceneChanged += ActiveSceneChanged;
        audioSource = this.GetComponent<AudioSource> ();

    }

    // Update is called once per frame
    void Update () {

    }

    void ActiveSceneChanged (Scene thisScene, Scene nextScene) {
        if (nextScene.name != "StageSelect" && nextScene.name != "StageSelect1" && nextScene.name != "StageSelect2") {
            audioSource.Stop ();
            Debug.Log (nextScene.name);
        }

    }

    void Awake () {
        DontDestroyOnLoad (this.gameObject);
    }

}