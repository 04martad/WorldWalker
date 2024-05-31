using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float horizontalSpeed = 5f; // Velocidad de movimiento horizontal
    public float verticalSpeed = 3f;   // Velocidad de movimiento vertical

    void Update()
    {
        // Movimiento horizontal automático
        float horizontalMovement = horizontalSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * horizontalMovement);

        // Movimiento vertical controlado por el usuario
        float verticalInput = Input.GetAxis("Vertical");
        float verticalMovement = verticalSpeed * verticalInput * Time.deltaTime;
        transform.Translate(Vector3.up * verticalMovement);
    }
}
