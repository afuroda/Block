using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class TextMashPro2 : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI textbox_name;

    // Start is called before the first frame update
    void Start () {
        Common2.WinResult2 = false;

        Common2.LoseResult2 = false;

        textbox_name = this.GetComponent<TextMeshProUGUI> ();
        textbox_name.text = " ";
    }

    // Update is called once per frame
    void Update () {

        if (Common2.WinResult2 == true) {
            textbox_name.text = "GAME\r\nCLEAR!!";
            Botton2.OneMoreBtn2.SetActive (true);
            NextBtn2.NextBottton2.SetActive (true);
        } else if (Common2.LoseResult2 == true) {
            textbox_name.text = "GAME\r\nOVER!!";
            Botton2.OneMoreBtn2.SetActive (true);
            NextBtn2.NextBottton2.SetActive (true);
        }
    }
}