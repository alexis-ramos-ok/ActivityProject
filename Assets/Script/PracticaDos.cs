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
        // Generamos tres números aleatorios entre -100 y 100
        float num1 = Random.Range(-100f, 100f);
        float num2 = Random.Range(-100f, 100f);
        float num3 = Random.Range(-100f, 100f);

        // Llamar a la función comparadora del ejercicio 1 con valores aleatorios
        string resultado = Comparador(num1, num2, num3);

        // Imprimir el resultado en la consola de Unity
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
