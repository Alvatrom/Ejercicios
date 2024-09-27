using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1 = 100 , numero2 = 50;
    // Start is called before the first frame update
    void Start()
    {
        if(numero1 >= numero2)
        {
            while (numero1 >= numero2)
            {
                if(numero2 % 2 == 0)
                {
                    Debug.Log("Numero par encontrado = " + numero2);
                }
                numero2++;
            }
        } 
        else if(numero2>= numero1)
        {
            while (numero2 >= numero1)
            {
                if (numero1 % 2 == 0)
                {
                    Debug.Log("Numero par encontrado = " + numero1);
                }
                numero1++;
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void CombrobarPares(int numero1,int numero2)
    {

    }*/
}
