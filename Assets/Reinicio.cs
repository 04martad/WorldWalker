using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarJuego : MonoBehaviour
{
    // M�todo para reiniciar el juego
    public void Reiniciar()
    {
        // Cargar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
