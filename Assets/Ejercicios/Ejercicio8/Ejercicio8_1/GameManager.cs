using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje personaje1;
    [SerializeField] Personaje personaje2;
    private bool yaEjecutado = false;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
            yaEjecutado = true;  // Impide que se ejecute más de una vez
        }
    }
    void PrepararPersonajes()
    {
        personaje1.Nombre = "Pedro";
        personaje1.Vida = 100;
        personaje1.CalcularNivel(3545);
        Debug.Log("Nombre; "+ personaje1.Nombre + " Vida; "+ personaje1.Vida + " Nivel; "+ personaje1.CalcularNivel(3545));

        personaje2.Nombre = "Juan";
        personaje2.Vida = 100;
        personaje2.CalcularNivel(44455);
        Debug.Log("Nombre; "+ personaje2.Nombre + " Vida; "+ personaje2.Vida + " Nivel; "+ personaje2.CalcularNivel(44455));

    }

}
