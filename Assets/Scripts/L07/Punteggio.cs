using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    public static int punteggio;
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        punteggio = 0;
        scoreDisplay.text = "Punteggio: " + punteggio.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Punteggio: " + punteggio.ToString();

        if (Input.GetButtonDown("Fire1")) {
            punteggio = punteggio + 1;
        }
    }
}
