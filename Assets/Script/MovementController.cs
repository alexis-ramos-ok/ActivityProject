using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Velocidad de movimiento y fuerza de salto
    public float movementSpeed = 1, jumpForce = 5;

    // Capa a utilizar para detectar el suelo
    public LayerMask castLayer;

    // Referencia al componente Rigidbody2D del personaje
    private Rigidbody2D rbody;

    // Se llama al iniciar el script
    private void Start()
    {
        // Se obtiene el componente Rigidbody2D asociado al GameObject
        rbody = GetComponent<Rigidbody2D>();
    }

    // Se llama en cada frame para capturar inputs y aplicar movimiento
    private void Update()
    {
        // Movimiento horizontal: se aplica velocidad en el eje X según el input de las flechas o A/D
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody.velocity.y);

        // Verificar si el personaje está en el suelo antes de permitir el salto
        bool isGrounded = CheckForGround();

        // Si la tecla de espacio se presiona y el personaje está en el suelo, salta
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    // Función para aplicar la lógica de salto
    private void Jump()
    {
        // Aplicar fuerza de salto en el eje Y manteniendo la velocidad horizontal
        rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
        // Alternativa: rbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    // Función para comprobar si el personaje está tocando el suelo usando CircleCast
    private bool CheckForGround()
    {
        // Lanzar un círculo hacia abajo para detectar si hay suelo (capa especificada en castLayer)
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, 1, Vector2.down, 0.6f, castLayer);

        // Si el círculo colisiona con un objeto, verifica si es el suelo usando su tag
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Floor"))
            {
                return true;
            }
        }

        return false; // Si no toca el suelo, devuelve false
    }

    // Dibuja una línea en el editor para visualizar dónde se lanza el CircleCast
    void OnDrawGizmosSelected()
    {
        // Color amarillo para el gizmo (solo visible cuando el objeto está seleccionado)
        Gizmos.color = Color.yellow;

        // Dibuja una línea hacia abajo para mostrar el rango del CircleCast
        Gizmos.DrawRay(transform.position, Vector2.down * 0.6f);
    }
}
