using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5f;   // Velocidad de movimiento
    public float rotationSpeed = 720f;  // Velocidad de rotaci�n

    private Rigidbody rb;  // Referencia al Rigidbody del jugador

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Obtener el componente Rigidbody del jugador
    }

    void Update()
    {
        // Obtener las entradas de movimiento horizontal (A/D o flechas izquierda/derecha) y vertical (W/S o flechas arriba/abajo)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular la direcci�n de movimiento relativa a la orientaci�n del jugador
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        // Si hay movimiento, aplicar la l�gica de movimiento y rotaci�n
        if (moveDirection.magnitude >= 0.1f)
        {
            // Calcular el �ngulo de rotaci�n basado en la direcci�n de entrada
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;

            // Interpolaci�n suave para rotar el personaje
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);

            // Aplicar la rotaci�n del personaje
            transform.rotation = Quaternion.Euler(0, angle, 0);

            // Mover al personaje en la direcci�n deseada
            Vector3 move = transform.forward * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + move);
        }
    }
}
