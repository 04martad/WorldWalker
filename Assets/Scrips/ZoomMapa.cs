using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomMove : MonoBehaviour
{

    // Factor de zoom (incremento o decremento en el tamaño de la cámara)
    public float zoomSpeed = 1.0f;
    // Límites para el zoom (mínimo y máximo)
    public float minZoom = 1.0f;
    public float maxZoom = 5.0f;
    // Método para manejar el zoom
    void Update()
    {
        // Obtener el input de scroll del mouse
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        // Calcular el nuevo tamaño de la cámara
        Camera.main.orthographicSize -= scroll * zoomSpeed;
        // Asegurarse de que el tamaño de la cámara esté dentro de los
       // límites
    Camera.main.orthographicSize =
    Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
    }
}

