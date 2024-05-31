using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontalAutomatico : MonoBehaviour
{
    public float velocidad = 5f;  // Velocidad de movimiento horizontal
    public float limiteIzquierdo = -10f;  // Límite izquierdo
    public float limiteDerecho = 10f;  // Límite derecho

    private int direccion = 1;  // Dirección del movimiento (1 = derecha, -1 = izquierda)

    void Update()
    {
        // Mover el personaje en la dirección actual
        transform.Translate(Vector3.right * direccion * velocidad * Time.deltaTime);

        // Verificar si ha alcanzado los límites y cambiar la dirección
        if (transform.position.x >= limiteDerecho)
        {
            direccion = -1;  // Cambiar dirección a la izquierda
        }
        else if (transform.position.x <= limiteIzquierdo)
        {
            direccion = 1;  // Cambiar dirección a la derecha
        }
    }
}
