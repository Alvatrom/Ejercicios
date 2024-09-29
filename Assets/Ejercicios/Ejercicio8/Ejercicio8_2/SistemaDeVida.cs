using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaInicial = 200, cantidad =30;
    float vidaActual, danho;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // asegurar que la vida inicial es la vida actual
    public void IniciarVida()
    {
        vidaActual = vidaInicial;

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
