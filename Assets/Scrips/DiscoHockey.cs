using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoHockey : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float tiempoDeVida;

    private void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * velocidadMovimiento*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("goal"))
        {
            Destroy(gameObject);
        }
    }
}
