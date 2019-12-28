using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int Pincount;

    public Text text;

    void Start()
    {
        Pincount = 0;
    }

    void Update()
    {
        text.text = Pincount.ToString();
    }
}
