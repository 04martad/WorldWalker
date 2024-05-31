using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTopDown : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;

    [SerializeField] private Vector2 direccion;

    private Rigidbody2D rb2D;

    private float movimientoX;

    private float movimientoY;

    private Animator animator;

   

    private void Start()
    {
        animator= GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        movimientoX = Input.GetAxisRaw("Horizontal");
        movimientoY = Input.GetAxisRaw("Vertical");
        animator.SetFloat("MovimientoX", movimientoX);
        animator.SetFloat("MovimientoY", movimientoY);

        if(movimientoX!=0 || movimientoY!=0)
        {
            animator.SetFloat("xidle", movimientoX);
            animator.SetFloat("yidle",movimientoY) ;
        }
           
        direccion = new Vector2(movimientoX,movimientoY).normalized;
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position+direccion*velocidadMovimiento*Time.fixedDeltaTime);
    }
}
