using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suono : MonoBehaviour
{
    // Quale suono
    // Quando dobbiamo iniziare a suonarlo
    // Quando dobbiamo finire

    private FMOD.Studio.EventInstance istanza;

    public float pitch;
    private float volume;

    void Start()
    {
        // FMODUnity.RuntimeManager.PlayOneShot("event:/Tone");
        istanza = FMODUnity.RuntimeManager.CreateInstance("event:/Tone");
        istanza.start();
    }

    void Update()
    {
        Debug.Log(Punteggio.punteggio);
        volume = 1.0f / Punteggio.punteggio + 1.0f;
        istanza.setParameterByName("Volume", volume);
        istanza.setParameterByName("Pitch", pitch);
        if (Variabili_Globali.azzeraAudio == true) {
            istanza.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
}
