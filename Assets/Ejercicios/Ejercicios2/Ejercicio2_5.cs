using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 0, vidasPlayer2Inicial = 1, vidasPlayer2 = 1, vidasPlayer3 = 2, vidasPlayer4 =3;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2Inicial;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
