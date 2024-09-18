using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] double radio = 3f, baseTriangulo = 4f, altura = 4f, lado = 4f;
    // Start is called before the first frame update
    void Start()
    {
        AreaCuadrado(lado);
        ConvertirAreaCuadrado(AreaCuadrado(lado));
        
    }

    
    double AreaCuadrado(double lado)
    {
        double areaCuadrado = lado * lado;
        return areaCuadrado;
    }
    double AreaTriangulo(double baseTriangulo, double altura)
    {
        double areaTriangulo = (baseTriangulo * altura) / 2;
        return areaTriangulo;
    }
    double AreaCirculo(double radio)
    {
        double areaCirculo = (radio * radio) * Mathf.PI;
        return areaCirculo;
    }


    double ConvertirAreaCuadrado(double AreaCuadrado)
    {
        double cantidad = 0f;
         cantidad = AreaCuadrado + (AreaCuadrado * 0.1);
        Debug.Log("El area introducido es = a " + cantidad + " en dolares");
        return cantidad;
    }
    double ConvertirAreaTriangulo(double AreaTriangulo)
    {
        double cantidad = 0f;
        cantidad = AreaTriangulo + (AreaTriangulo * 0.1);
        Debug.Log("El area introducido es = a " + cantidad + " en dolares");
        return cantidad;
    }
    double ConvertirAreaCirculo(double AreaCirculo)
    {
        double cantidad = 0f;
        cantidad = AreaCirculo + (AreaCirculo * 0.1);
        Debug.Log("El area introducido es = a " + cantidad + " en dolares");
        return cantidad;
    }

}
