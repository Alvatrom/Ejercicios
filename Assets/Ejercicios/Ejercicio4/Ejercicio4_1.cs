using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float radio = 3f, baseTriangulo = 4f, altura = 4f, lado = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Area de cuadrado = ");
        AreaCuadrado(lado);
        Debug.Log("Area de triangulo = ");
        AreaTriangulo(baseTriangulo, altura);
        Debug.Log("Area de circulo = ");
        AreaCirculo(radio);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float AreaCuadrado(float lado)
    {
        float areaCuadrado = lado* lado;
        return areaCuadrado;
    }
    float AreaTriangulo(float baseTriangulo,float altura)
    {
        float areaTriangulo = (baseTriangulo * altura) / 2;
        return areaTriangulo;
    }
    float AreaCirculo(float radio)
    {
        float areaCirculo = (radio* radio)* Mathf.PI;
        return areaCirculo;
    }
}
