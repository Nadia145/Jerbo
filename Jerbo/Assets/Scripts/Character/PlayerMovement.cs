using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nad*/

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float velocidadMovimiento;
    private float fuerzaSalto;
    private bool estaSaltando;
    private float movimientoHorizontal;
    private float movimientoVertical;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        velocidadMovimiento = 3f;
        fuerzaSalto = 60f;
        estaSaltando = false;
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        movimientoVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        
    }
}
