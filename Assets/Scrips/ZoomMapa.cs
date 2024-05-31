using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomMove : MonoBehaviour
{

    // Factor de zoom (incremento o decremento en el tama�o de la c�mara)
    public float zoomSpeed = 1.0f;
    // L�mites para el zoom (m�nimo y m�ximo)
    public float minZoom = 1.0f;
    public float maxZoom = 5.0f;
    // M�todo para manejar el zoom
    void Update()
    {
        // Obtener el input de scroll del mouse
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        // Calcular el nuevo tama�o de la c�mara
        Camera.main.orthographicSize -= scroll * zoomSpeed;
        // Asegurarse de que el tama�o de la c�mara est� dentro de los
       // l�mites
    Camera.main.orthographicSize =
    Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
    }
}

