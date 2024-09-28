
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1 = 100, numero2 = 30;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 > numero2)
        {
            for (int i = numero2; i <= numero1; i++)
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

    // Update is called once per frame
    void Update()
    {

    }
}