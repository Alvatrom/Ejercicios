using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float altura = 1.0f, baseTriangulo = 3f;//que detecta cuando pones base?
    // Start is called before the first frame update
    void Start()
    {
        float area = 1.0f;
        area = (baseTriangulo * altura)/2;
        Debug.Log(area);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
