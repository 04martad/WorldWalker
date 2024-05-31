using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaColision1 : MonoBehaviour
{
    private bool juegoPausado = false;

    private void PausarJuego()
    {
        Time.timeScale = 0f; // Pausar el tiempo en el juego
        juegoPausado = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobar si la colisión involucra a dos sprites
        if (collision.gameObject.CompareTag("goal") && collision.gameObject.CompareTag("puck"))
        {
            // Pausar el juego si aún no está pausado
            if (!juegoPausado)
            {
                PausarJuego();
            }
        }
    }
}
