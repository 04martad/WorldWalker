using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // Cantidad máxima de vidas
    private int currentHealth; // Vidas actuales

    void Start()
    {
        currentHealth = maxHealth; // Configurar las vidas iniciales
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Reducir las vidas cuando el jugador recibe daño

        if (currentHealth <= 0)
        {
            Die(); // Si el jugador se queda sin vidas, llamar a la función Die()
        }
    }

    void Die()
    {
        // Aquí puedes agregar cualquier lógica adicional que desees ejecutar cuando el jugador muera,
        // como reiniciar la escena, mostrar una pantalla de Game Over, etc.
        Debug.Log("El jugador ha muerto.");
        // Por ejemplo, puedes reiniciar la escena:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
