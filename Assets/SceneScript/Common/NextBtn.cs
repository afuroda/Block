using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBtn : MonoBehaviour
{
    public static GameObject NextBottton;
    // Start is called before the first frame update
    void Start()
    {
        NextBottton = this.gameObject;
        NextBottton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
