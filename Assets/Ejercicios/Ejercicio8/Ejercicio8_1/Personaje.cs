using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] Personaje enemigo;
    [SerializeField] SistemaDeVida miSistemaDeVidas;
    [SerializeField] Arma miArma;

    // de esta manera podemos asignarle teclas especificas para los distintos personajes
    [SerializeField] KeyCode teclaCurar = KeyCode.B;
    [SerializeField] KeyCode teclaAtacar = KeyCode.N;
    [SerializeField] KeyCode teclaRecargar = KeyCode.M;
    //COMO se define mi personaje
    //Propiedades o atributos
    private float vida = 200f, danno = 100f, velocidad = 38f;
    private string nombre;
    private bool miTurno = false;

    public float Danno { get => danno; set => danno = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }

    void Start()
    {
        //asegurar que el sistema de vida y arma inicien correctamente
        if (miSistemaDeVidas != null)
        {
            miSistemaDeVidas.IniciarVida();
        }

        if (miArma != null)
        {
            miArma.IniciarMunicion();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(teclaCurar))
        {
            CurarPersonaje(20); // Curar 20 puntos de vida
        }

        // Detectar si se presiona la tecla asignada para atacar
        if (Input.GetKeyDown(teclaAtacar))
        {
            Atacar();
        }

        // Detectar si se presiona la tecla asignada para recargar
        if (Input.GetKeyDown(teclaRecargar))
        {
            RecargarArma();
        }
    }

    //QUE puede hacer mi personaje
    //Funcionalidades


    /*public void Movimiento(float x,float y, float z)
    {

    }
    public void Atacar()
    {

    }
    public void Saltar()
    {

    }*/

    private void CurarPersonaje(float cantidad)
    {
        float nuevaVida = miSistemaDeVidas.RecibirCura(cantidad);
        if (nuevaVida == -1)
        {
            //poniendo el $ antes de las 1º comillas te ahorras el poner los + y el resto de comillas (haces una cadena con el $ y pones las variables entre{}
            Debug.Log($"{nombre} no puede recibir valores negativos de curación.");
        }
        else
        {
            Debug.Log($"{nombre} ha tomado pocion. Vida actual: {nuevaVida}");
        }
    }

    private void Atacar()
    {
        int resultadoUsoArma = miArma.UtilizarArma();

        //arma tiene municion == 0
        if (resultadoUsoArma == 0)
        {
            // random de daño entre el valor min y max
            float danho = Random.Range(miArma.DanhoMinimo, miArma.DanhoMaximo);
            enemigo.RecibirDanho(danho);
            Debug.Log($"{nombre} ataco a {enemigo.nombre} haciendole un total de = {danho} daño");
        }
        else
        {
            Debug.Log($"{nombre} sin municion. Recargando... ");
        }
    }
    private void RecargarArma()
    {
        int resultadoRecarga = miArma.RecargarArma();

        //recargando
        if (resultadoRecarga == 0)
        {
            Debug.Log($"{nombre} ha recargado su arma.");
        }
        else
        {
            // ya esta recargada
            Debug.Log($"{nombre} arma ya cargada.");
        }
    }
    public void RecibirDanho(float danho)
    {
        float vidaActual = miSistemaDeVidas.RecibirDanho(danho);
        if (vidaActual <= 0)
        {
            Debug.Log($"{nombre} eliminado.");
        }
        else if (vidaActual == -1)
        {
            Debug.Log($"{nombre} no puede recibir una cantidad negativa de daño.");
        }
        else
        {
            Debug.Log($"{nombre} ha recibido {danho} de daño. Vida actual: {vidaActual}");
        }
    }
    public float CalcularNivel(int experiencia)
    {
        float nivel = experiencia / 1000;
        Debug.Log(nivel);
        return nivel;
    }
}
