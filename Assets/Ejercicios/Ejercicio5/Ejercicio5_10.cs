using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int tP = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ComporbarTemperatura(int tP)
    {
        if(tP <= 10)
        {
            Debug.Log("El clima es frio");
        }
        else if(10< tP && tP<=20)
        {
            Debug.Log("El clima es nublado");
        }
        else if (20 < tP && tP <= 30)
        {
            Debug.Log("El clima es caluroso");
        }
        else if (tP > 30)
        {
            Debug.Log("El clima es tropical");
        }
        else
        {
            Debug.Log("Poner un valor valido");
        }
    }
}
