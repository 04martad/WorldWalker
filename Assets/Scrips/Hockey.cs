using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hockey : MonoBehaviour
{
    [SerializeField] private Transform controladordisparo;
    [SerializeField] private GameObject balaPrefab;
   

    

    private void Update()
    {
   
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
            
        }


    }

    private void Disparar()
    {
        Instantiate(balaPrefab, controladordisparo.position, controladordisparo.rotation);
    }
}
