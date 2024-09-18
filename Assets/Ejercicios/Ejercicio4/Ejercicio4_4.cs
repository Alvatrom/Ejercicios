using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float KmPorHora = 23.3f;
    // Start is called before the first frame update
    void Start()
    {
        ConvertidorAMetrosPorSegundo(KmPorHora);
        Debug.Log("Son en total " + ConvertidorAMetrosPorSegundo(KmPorHora) + "m/s");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    double ConvertidorAMetrosPorSegundo(float kmPorHora)
    {
        double metrosPorSegundo = 0;
        metrosPorSegundo = kmPorHora / 3.6;
        return metrosPorSegundo;
    }
}
