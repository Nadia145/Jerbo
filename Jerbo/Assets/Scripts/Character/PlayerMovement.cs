using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nad*/

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    public float velocidadMovimiento;
    public float fuerzaSalto;
    private bool estaSaltando;
    private float movimientoHorizontal;
    private float movimientoVertical;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        estaSaltando = false;
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        movimientoVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (movimientoHorizontal > 0.1f || movimientoHorizontal < -0.1f) 
        {
            rb2D.AddForce(new Vector2(movimientoHorizontal * velocidadMovimiento, 0f), ForceMode2D.Impulse);
        }
        if (!estaSaltando && movimientoVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, movimientoVertical * fuerzaSalto), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform") 
        {
            estaSaltando = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        estaSaltando = true;
    }
}
