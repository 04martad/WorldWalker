using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontalAutomatico : MonoBehaviour
{
    public float velocidad = 5f;  // Velocidad de movimiento horizontal
    public float limiteIzquierdo = -10f;  // L�mite izquierdo
    public float limiteDerecho = 10f;  // L�mite derecho

    private int direccion = 1;  // Direcci�n del movimiento (1 = derecha, -1 = izquierda)

    void Update()
    {
        // Mover el personaje en la direcci�n actual
        transform.Translate(Vector3.right * direccion * velocidad * Time.deltaTime);

        // Verificar si ha alcanzado los l�mites y cambiar la direcci�n
        if (transform.position.x >= limiteDerecho)
        {
            direccion = -1;  // Cambiar direcci�n a la izquierda
        }
        else if (transform.position.x <= limiteIzquierdo)
        {
            direccion = 1;  // Cambiar direcci�n a la derecha
        }
    }
}
