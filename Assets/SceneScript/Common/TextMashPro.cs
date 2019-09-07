using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class TextMashPro : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI textbox_name;

    // Start is called before the first frame update
    void Start () {
        Common.WinResult = false;

        Common.LoseResult = false;

        textbox_name = this.GetComponent<TextMeshProUGUI> ();
        textbox_name.text = " ";
    }

    // Update is called once per frame
    void Update () {

        if (Common.WinResult == true) {
            textbox_name.text = "GAME\r\nCLEAR!!";
            Botton.OneMoreBtn.SetActive (true);
            NextBtn.NextBottton.SetActive (true);
        } else if (Common.LoseResult == true) {
            textbox_name.text = "GAME\r\nOVER!!";
            Botton.OneMoreBtn.SetActive (true);

        }
    }
}