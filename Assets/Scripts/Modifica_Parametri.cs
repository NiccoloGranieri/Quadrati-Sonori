using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifica_Parametri : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    // Se vogliamo caricare l'evento da fuori possiamo usare questa variabile
    // public FMODUnity.EventReference fmodEvent;


    [SerializeField] [Range(0f, 1f)]
    private float pitch;

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance("event:/Tone");
        instance.start();
    }

    void Update()
    {
        instance.setParameterByName("Pitch", pitch);
        if (Variabili_Globali.azzeraAudio) {
            instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
}
