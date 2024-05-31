using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CombateJugador : MonoBehaviour
{
    [SerializeField] private int vida;
    public GameObject MenuHockeyt;

    

    public void TomarDaño(int cantidadDaño)
    {
        vida -= cantidadDaño;
        if(vida <= 0)
        {                       
               MenuHockeyt.SetActive(true);
                    
        }
    }
   

  
}
