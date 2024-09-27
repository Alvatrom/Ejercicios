using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numero = 30;
    // Start is called before the first frame update
    void Start()
    {
        int inicio = 1;
        if (numero > 1)
        {
            while (numero >= inicio)
            {
                if (inicio % 3 == 0)
                {
                    Debug.Log("Numero multiplo de 3 encontrado = " + inicio);
                }
                inicio++;
            }
        }
        else if (inicio >= numero)
        {
            while (numero <= inicio)
            {
                if (inicio % 3 == 0)
                {
                    Debug.Log("Numero multiplo de 3 encontrado = " + inicio);
                }
                inicio--;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
