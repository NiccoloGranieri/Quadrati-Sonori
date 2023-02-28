using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variabili_Globali : MonoBehaviour
{
    public static bool azzeraAudio;

    // Start is called before the first frame update
    void Start()
    {
        azzeraAudio = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(azzeraAudio);
    }
}
