using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Etiqueta del objeto que puede destruir este objeto
    public string PlayerTag = "Player";

    // Método llamado cuando otro collider entra en contacto con el collider de este objeto
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que entró en contacto tiene la etiqueta especificada
        if (other.gameObject.CompareTag(PlayerTag))
        {
            // Destruir este objeto
            Destroy(gameObject);
        }
    }
}
