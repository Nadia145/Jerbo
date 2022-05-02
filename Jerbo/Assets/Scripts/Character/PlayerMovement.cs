using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nad y Pablo*/

public class PlayerMovement : MonoBehaviour
{
    [Header("Componentes")]
    private Rigidbody2D rb2D;
    public Animator animatorPersonaje;

    [Header("Layer Masks")]
    [SerializeField] private LayerMask capaTierra;

    [Header("Variables Caminar")]
    [SerializeField] private float movimientoAceleracion;
    [SerializeField] private float maximaVelocidadMovimiento;
    [SerializeField] private float linearDrag;
    private float movimientoHorizontal;
    private bool mirandoDerecha = true;
    private bool cambiarDireccion => (rb2D.velocity.x > 0f && movimientoHorizontal < 0f) || (rb2D.velocity.x < 0f && movimientoHorizontal > 0f);

    [Header("Variables Salto")]
    [SerializeField] private float fuerzaSalto = 12f;
    [SerializeField] private float aireLinearDrag = 2.5f;
    [SerializeField] private float multiplicadorCaida = 8f;
    [SerializeField] private float multiplicadorCaidaSaltoBajo = 5f;
    [SerializeField] private int saltosExtra = 1;
    private int valorSaltosExtra;
    private bool puedeSaltar => Input.GetButtonDown("Jump"/*Omi esta linea*/) && (tocandoTierra || valorSaltosExtra > 0);

    [Header("Variables Colisiones Tierra")]
    [SerializeField] private float longitudRaycastTierra;
    private bool tocandoTierra;

    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movimiento
        movimientoHorizontal = ObtenerInput().x;
        if (puedeSaltar)
        {
            animatorPersonaje.SetBool("EstaSaltando", true);
            SaltoPersonaje();
        }
        else if (!puedeSaltar)
        {
            animatorPersonaje.SetBool("EstaSaltando", false);
        }

        //Animaciones
        animatorPersonaje.SetFloat("VelocidadPersonaje", Mathf.Abs(movimientoHorizontal));
    }

    //Aqui empiezan las funciones para el movimiento del personaje
    private void FixedUpdate()
    {
        ChecarColisiones();
        MovimientoPersonaje();
        if (tocandoTierra)
        {
            valorSaltosExtra = saltosExtra;
            AplicarTierraLinearDrag();
        }
        else 
        {
            AplicarAireLinearDrag();
            MultiplicadorCaida();
        }
    }

    private Vector2 ObtenerInput()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void MovimientoPersonaje() 
    {
        rb2D.AddForce(new Vector2(movimientoHorizontal, 0f) * movimientoAceleracion);

        if (Mathf.Abs(rb2D.velocity.x) > maximaVelocidadMovimiento) 
        {
            rb2D.velocity = new Vector2(Mathf.Sign(rb2D.velocity.x) * maximaVelocidadMovimiento, rb2D.velocity.y);
        }

        if (movimientoHorizontal > 0 && !mirandoDerecha)
        {
            Flip();
        }
        else if (movimientoHorizontal < 0 && mirandoDerecha) 
        {
            Flip();
        }
    }

    private void AplicarTierraLinearDrag() 
    {
        if (Mathf.Abs(movimientoHorizontal) < 0.4f || cambiarDireccion)
        {
            rb2D.drag = linearDrag;
        }
        else
        {
            rb2D.drag = 0f;  
        }
    }

    private void AplicarAireLinearDrag()
    {
        rb2D.drag = aireLinearDrag;
    }

    private void Flip() 
    {
        mirandoDerecha = !mirandoDerecha;

        Vector2 laEscala = transform.localScale;
        laEscala.x *= -1;
        transform.localScale = laEscala;
    }
    //Aqui terminan las funciones para el movimiento del personaje



    //Aqui empiezan las funciones para el salto del personaje
    private void SaltoPersonaje()
    {
        if (!tocandoTierra)
            saltosExtra--;
        rb2D.velocity = new Vector2(rb2D.velocity.x, 0f);
        rb2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }

    private void MultiplicadorCaida() 
    {
        if (rb2D.velocity.y < 0)
        {
            rb2D.gravityScale = multiplicadorCaida;
        }
        else if (rb2D.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb2D.gravityScale = multiplicadorCaidaSaltoBajo;
        }
        else
        {
            rb2D.gravityScale = 1f;
        }
    }

    private void ChecarColisiones() 
    {
        tocandoTierra = Physics2D.Raycast(transform.position * longitudRaycastTierra, Vector2.down, longitudRaycastTierra, capaTierra);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * longitudRaycastTierra);
    }
    //Aqui terminan las funciones para el salto del personaje



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Headphones"))
        {
            Destroy(collision.gameObject);
        }
    }
}
