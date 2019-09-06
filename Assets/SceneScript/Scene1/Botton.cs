using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Botton : MonoBehaviour
{

    public static GameObject OneMoreBtn;
    // Start is called before the first frame update
    void Start()
    {
        OneMoreBtn = this.gameObject;
        OneMoreBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
