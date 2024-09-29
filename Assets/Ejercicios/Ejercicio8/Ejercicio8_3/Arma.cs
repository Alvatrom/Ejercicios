using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMin, danhoMax;
    [SerializeField] int capacidadTotal = 30;
    [SerializeField] bool automatica;
    int municionActual;

    //para que pueda ver el valor del da�o min y max
    public float DanhoMinimo { get { return danhoMin; } }
    public float DanhoMaximo { get { return danhoMax; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IniciarMunicion()
    {
        municionActual = capacidadTotal;
    }

    public int UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
            Debug.Log("Munici�n restante: " + municionActual);
            return 0;
        }
        else
        {
            Debug.Log("Sin munici�n");
            return -1;
        }
    }

    public int RecargarArma()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            Debug.Log("Recargando, munici�n actual: " + municionActual);
            return 0;
        }
        else
        {
            Debug.Log("Arma recargada");
            return -1;
        }
    }
    
}
