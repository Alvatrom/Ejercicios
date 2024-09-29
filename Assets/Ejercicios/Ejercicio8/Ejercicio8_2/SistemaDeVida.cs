using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaInicial = 200;
    float vidaActual, cantidad, danho;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float RecibirCura(float cantidad)
    {
        if(cantidad > 0)
        {
            vidaActual += cantidad;
            return vidaActual;
        }
        else if(cantidad < 0)
        {
            return -1;
        }
        return vidaActual;

    }
    public float RecibirDanho(float danho)
    {
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            return 0;
        }
        else if(vidaActual > 0)
        {
            vidaActual -= danho;
        }
        if (danho < 0)
        {
            return -1;
        }

        return vidaActual;
    }
}
