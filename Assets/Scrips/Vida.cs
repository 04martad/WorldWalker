using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // Cantidad m�xima de vidas
    private int currentHealth; // Vidas actuales

    void Start()
    {
        currentHealth = maxHealth; // Configurar las vidas iniciales
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Reducir las vidas cuando el jugador recibe da�o

        if (currentHealth <= 0)
        {
            Die(); // Si el jugador se queda sin vidas, llamar a la funci�n Die()
        }
    }

    void Die()
    {
        // Aqu� puedes agregar cualquier l�gica adicional que desees ejecutar cuando el jugador muera,
        // como reiniciar la escena, mostrar una pantalla de Game Over, etc.
        Debug.Log("El jugador ha muerto.");
        // Por ejemplo, puedes reiniciar la escena:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
