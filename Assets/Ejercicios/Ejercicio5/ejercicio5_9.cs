using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int[] danno = { 350, 300, 300, 310, 280, 360 };
    [SerializeField] int[] vida = { 650, 550, 500, 460, 490, 520 };
    [SerializeField] int tipo = 4;
    void Start()
    {
        ComprobarTipo(tipo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ComprobarTipo(int tipo)
    {
        if(tipo == 1)
        {
            Debug.Log("El enemigo tiene " + danno[0] + " de daño y "+ vida[0]+" de vida");
        }
        else if(tipo == 2)
        {
            Debug.Log("El enemigo tiene " + danno[1] + " de daño y "+ vida[1]+" de vida");

        }
        else if (tipo == 3)
        {
            Debug.Log("El enemigo tiene " + danno[2] + " de daño y "+ vida[2]+" de vida");

        }
        else if (tipo == 4)
        {
            Debug.Log("El enemigo tiene " + danno[3] + " de daño y "+ vida[3]+" de vida");

        }
        else if (tipo == 5)
        {
            Debug.Log("El enemigo tiene " + danno[4] + " de daño y "+ vida[4]+" de vida");


        }
        else if (tipo == 6)
        {
            Debug.Log("El enemigo tiene " + danno[5] + " de daño y "+ vida[5]+" de vida");

        }
        else
        {
            Debug.Log("escriba un tipo valido ( entre 1 y 6");
        }
    }
    /*(int, int) ComprobarTipo(int tipo)
    {
        if(tipo == 1)
        {
            Debug.Log("El enemigo tiene " + danno[0] + " de daño y "+ vida[0]+" de vida");
        }
    }*/

}
