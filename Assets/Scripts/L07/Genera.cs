using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genera : MonoBehaviour
{
    private Vector3 posizioneMouse;
    private Vector3 posizioneForma;
    public GameObject ilMioPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            posizioneMouse = Input.mousePosition;
            posizioneMouse.z = 10.0f;
            posizioneForma = Camera.main.ScreenToWorldPoint(posizioneMouse);
            Instantiate(ilMioPrefab, posizioneForma, Quaternion.identity);
            // Quaternion.identity setta la rotazione del cubo a 0 0 0, se volessi ruotarlo potrei dire quaternion.euler e specificare l'angolo di eulero.
        }
    }
}
