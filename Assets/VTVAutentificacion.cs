using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTVAutentificacion : MonoBehaviour
{

    public string PatenteDelAuto;
    public int ModeloDelAuto;
    public float KilometrosRecorridos;
    public int VencimientoVTV;
    public float HC;



    // Start is called before the first frame update
    void Start()
    {

        
        if (PatenteDelAuto == "")
        {
            Debug.Log("Debes completar el campo de la patente");
            return;
        }
        if (ModeloDelAuto < 1900 || ModeloDelAuto > 2025)
        {
            Debug.Log("El Año de fabricacion del auto esta mal");
            return;
        }
        if (KilometrosRecorridos < 0)
        {
            Debug.Log("El kilometraje del auto no puede ser negativo");
            return;
        }
        if (VencimientoVTV > 2025 || VencimientoVTV < ModeloDelAuto)
        {
            Debug.Log("El año de vencimiento esta incorrecto");
            return;
        }
        if (HC < 5 || HC > 100)
        {
            Debug.Log("El HC esta desaprobado");
            return;
        }


        Debug.Log("VTV no aprobada");

        Debug.Log("La VTV esta aprobada");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
