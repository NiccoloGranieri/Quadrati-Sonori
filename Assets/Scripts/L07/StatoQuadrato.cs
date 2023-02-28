using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatoQuadrato : MonoBehaviour
{
    public string Nome_Scena;

    void Start()
    {
        
    }

    void Update()
    {
        // if(gameObject.transform.position.y < -3)
        // {
    
        // }
        if(gameObject.transform.position.y < -4) 
        {
            Variabili_Globali.azzeraAudio = true;
            if(gameObject.transform.position.y < -10) 
            {
                Application.LoadLevel(Nome_Scena);
            }
        }
    }
}
