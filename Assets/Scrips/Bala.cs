using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private int daño;
    [SerializeField] private float tiempodevida;

    private void Start()
    {
        Destroy(gameObject, tiempodevida);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * velocidad*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<CombateJugador>().TomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
