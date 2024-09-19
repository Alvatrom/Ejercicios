using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //COMO se define mi personaje
    //Propiedades o atributos
    float vida = 200f, danno = 100f, velocidad = 38f;
    string nombre;

    public float Danno { get => danno; set => danno = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }

    //QUE puede hacer mi personaje
    //Funcionalidades
    public void Movimiento(float x,float y, float z)
    {

    }
    public void Atacar()
    {

    }
    public void Saltar()
    {

    }
}
