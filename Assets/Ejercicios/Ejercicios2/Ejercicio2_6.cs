using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 2, puntuacion2 = 3, puntuacion3 = 4;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        Mostrar(puntuacion1,puntuacion2,puntuacion3);


    }
    void Mostrar(int puntuacion1, int puntuacion2,int puntuacion3)
    {
        int media = 0;
        Debug.Log("Puntuacion 1 = " + puntuacion1);
        Debug.Log("Puntuacion 2 = " + puntuacion2);
        Debug.Log("Puntuacion 3 = " + puntuacion3);
        media= (puntuacion1+ puntuacion2+ puntuacion3)/3;
        Debug.Log("Puntuacion Media "+ media);

    }
}
