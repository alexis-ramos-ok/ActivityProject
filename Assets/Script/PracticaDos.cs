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

    //  Array de 10 números enteros dado y temporizador para hacer la modificación
    private int[] numeros = { 97, -64, -3, -58, -15, 58, 51, 38, -31, -37 };
    private float timer = 0f;

    // Variable de control para asegurar que tanto la modificación como la impresión
    // se hagan una sola vez
    private bool arrayModificado = false;

    void Update()
    {
        // Incrementa el temporizador con el tiempo transcurrido desde el último frame
        timer += Time.deltaTime;

        // Espera 4.5 segundos antes de modificar el array
        if (timer >= 4.5f && !arrayModificado)
        {
            // Llamar a la función que duplica los pares pasando el array como parámetro
            DuplicadorDePares(numeros);
            arrayModificado = true;

            // Convierte el array a string e imprime en consola
            string numerosString = string.Join(", ", numeros);
            Debug.Log("Array con valores de números pares duplicados: [" + numerosString + "]");
        }
    }

    // Función que recibe un array de enteros y duplica los valores pares,
    // los valores modificados se asignan al mismo array
    void DuplicadorDePares(int[] array)
    {
        // Recorre el array y duplica los números pares
        for (int i = 0; i < array.Length; i++)
        {
            // Si el número es par (divisible por 2 sin resto), duplicamos
            if (array[i] % 2 == 0)
            {
                array[i] *= 2;
            }
        }
    }
}
