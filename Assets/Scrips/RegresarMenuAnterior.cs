using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegresarMenuAnterior : MonoBehaviour
{
    // M�todo para regresar a la escena anterior
    public void Regresar()
    {
        // Obtener el �ndice de la escena anterior
        int indiceEscenaAnterior = SceneManager.GetActiveScene().buildIndex - 1;

        // Cargar la escena anterior si existe
        if (indiceEscenaAnterior >= 0)
        {
            SceneManager.LoadScene(indiceEscenaAnterior);
        }
        else
        {
            Debug.LogWarning("No hay escena anterior disponible.");
        }
    }
}