using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numero1 = 10, numero2 = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int SumarTodosLosNumeros(int numero1,int numero2)
    {
        if (numero1 > numero2)
        {
            for (int i = numero2; i <= numero1; i++)
            {
                Debug.Log(i);

                
            }
        }
        else if (numero1 < numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
                Debug.Log(i);

                if (i > 0)
                {
                    Debug.Log("Numero positivo");
                }
                else if (i < 0)
                {
                    Debug.Log("Numero negativo");
                }
                else
                {
                    Debug.Log("numero igual a 0");

                }
                if (i % 2 == 0)
                {
                    Debug.Log("Numero par");
                }
                else
                {
                    Debug.Log("Numero impar");

                }
            }
        }
    }
}
