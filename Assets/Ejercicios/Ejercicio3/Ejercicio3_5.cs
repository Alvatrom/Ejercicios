using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio = 3;
    // Start is called before the first frame update
    void Start()
    {
        float longitud = 3f, area = 3f;//Mathf.PI buscado por internet
        longitud = 2* Mathf.PI *radio;
        area = Mathf.PI * radio * radio;// no me deja poner ^porque no se permite en int ni float;
        Debug.Log("Area  del circulo = " + area + "longitud = " + longitud);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
