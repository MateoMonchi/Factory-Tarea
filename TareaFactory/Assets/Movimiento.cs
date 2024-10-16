using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5f;   // Velocidad de movimiento
    public float rotationSpeed = 720f;  // Velocidad de rotación

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

        // Calcular la dirección de movimiento relativa a la orientación del jugador
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        // Si hay movimiento, aplicar la lógica de movimiento y rotación
        if (moveDirection.magnitude >= 0.1f)
        {
            // Calcular el ángulo de rotación basado en la dirección de entrada
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;

            // Interpolación suave para rotar el personaje
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);

            // Aplicar la rotación del personaje
            transform.rotation = Quaternion.Euler(0, angle, 0);

            // Mover al personaje en la dirección deseada
            Vector3 move = transform.forward * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + move);
        }
    }
}
