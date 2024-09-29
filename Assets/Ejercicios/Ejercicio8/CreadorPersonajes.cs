using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    int numero = 5;
    string texto = "puti";
    float num = 34f;
    [SerializeField] Personaje link;
    [SerializeField] Personaje mario;

    // Start is called before the first frame update
    void Start()
    {
        link.Nombre = "Link";
        link.Vida = 100;
        link.Velocidad = 100;
        link.Danno = 100;
        link.Movimiento(2, 5, 1);

        mario.Vida = 100;
        mario.Velocidad = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
