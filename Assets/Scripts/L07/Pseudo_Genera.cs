using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pseudo_Genera : MonoBehaviour
{
    private Vector3 posizioneMouse;
    private Vector3 posizioneQuadrato;
    public GameObject ilMioQuadratoPrefab;

    void Start()
    {
        // Possiamo lasciare lo start vuoto
    }

    // Update is called once per frame
    void Update()
    {
        // Qui dovremmo mettere la maggiorparte del nostro codice!
        // Se sto cliccando o no

        if (Input.GetButtonDown("Fire1"))
        {
            posizioneMouse = Input.mousePosition;
            posizioneMouse.z = 10.0f;
            posizioneQuadrato = Camera.main.ScreenToWorldPoint(posizioneMouse);
            Instantiate(ilMioQuadratoPrefab, posizioneQuadrato, Quaternion.identity);
            // Debug.Log(posizioneMouse);
            // Prendere il quadrato dichiarato sopra
            // Metterlo nella posizione del puntatore
        }
    }
}
