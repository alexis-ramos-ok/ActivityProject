using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaDos : MonoBehaviour
{
    // Función comparadora que toma tres valores flotantes
    public string Comparador(float a, float b, float c)
    {

        // Determina el mayor y el menor de los valores tomados
        float mayor = Mathf.Max(a, b, c);
        float menor = Mathf.Min(a, b, c);

        // Calcula el promedio de los valores
        float promedio = (a + b + c) / 3f;

        // Comprobamos las condiciones y devolvemos un string
        if (mayor > 100)
        {
            return "Mayor fuera de rango";
        }
        else if (menor < 0)
        {
            return "Menor fuera de rango";
        }
        else
        {
            // Devuelve el promedio con dos decimales
            return "El valor promedio es: " + promedio.ToString("F2");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
