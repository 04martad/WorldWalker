using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject panelFelicitaciones;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobamos si el objeto con el que colisionamos tiene el tag "Jugador"
        if (collision.gameObject.CompareTag("Colision"))
        {
            // Mostramos el panel de felicitaciones
            panelFelicitaciones.SetActive(true);
        }
    }
}
