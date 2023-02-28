using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suono_Quadrato : MonoBehaviour
{
    void Start()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Tone");
    }

    void Update()
    {

    }
}
