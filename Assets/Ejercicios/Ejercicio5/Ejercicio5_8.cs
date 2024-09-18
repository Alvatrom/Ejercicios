using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H = 23, M = 43, S = 34;
    // Start is called before the first frame update
    void Start()
    {
       ComprobarHora(H,M,S); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ComprobarHora(int H, int M, int S)
    {
        if(H <=24 &&  M <=60 && S <= 60)
        {
            Debug.Log(H+":"+M+":"+S);
        }
        else
        {
            Debug.Log("Poner una hora correcta");
        }
    }
}
