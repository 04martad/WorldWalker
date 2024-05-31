using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EscribirTextoTMP : MonoBehaviour
{
    public TextMeshProUGUI cuadroDeTexto;
    public string mensaje;
    public float velocidadEscritura = 0.05f;

    void Start()
    {
        // Inicia la coroutine para escribir el texto
        StartCoroutine(EscribirLetraPorLetra());
    }

    IEnumerator EscribirLetraPorLetra()
    {
        cuadroDeTexto.text = ""; // Asegurarse de que el cuadro de texto est� vac�o al iniciar

        foreach (char letra in mensaje.ToCharArray())
        {
            cuadroDeTexto.text += letra; // A�adir una letra al texto
            yield return new WaitForSeconds(velocidadEscritura); // Esperar antes de a�adir la siguiente letra
        }
    }
}
