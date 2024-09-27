using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1 = 2, numero2 = 6;
    // Start is called before the first frame update
    void Start()
    {
        ComprobarNumero(numero1,numero2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ComprobarNumero(int numero1,int numero2)
    {
        if(numero1<numero2)
        {
            for (int i = numero1; i <= numero2; i++)//tiene que tener el nº 2 +1?
            {
                Debug.Log(i);

            }
        }
        else if(numero2< numero1)
        {
            for (int i = numero2; i <= numero1; i++)//tiene que tener el nº 1 +1?
            {
                Debug.Log(i);

            }
        }
        else
        {
            Debug.Log("Los numero son iguales");
        }
    }
}
