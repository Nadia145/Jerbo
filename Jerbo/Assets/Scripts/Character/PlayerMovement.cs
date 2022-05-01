using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Nad y Pablo*/

public class PlayerMovement : MonoBehaviour
{
    [Header("Componentes")]
    private Rigidbody2D rb2D;

    [Header("Layer Masks")]
    private LayerMask capaTierra;

    [Header("Variables Caminar")]
    [SerializeField] private float movimientoAceleracion;
    [SerializeField] private float maximaVelocidadMovimiento;
    [SerializeField] private float linearDrag;
    private float movimientoHorizontal;
    private bool cambiarDireccion => (rb2D.velocity.x > 0f && movimientoHorizontal < 0f) || (rb2D.velocity.x < 0f && movimientoHorizontal > 0f);

    [Header("Variables Salto")]
    [SerializeField] private float fuerzaSalto = 12f;
    public float multiplicadorCaida = 2.5f;
    public float multiplicadorSaltoBajo = 2f;

    [Header("Variables Colisiones Tierra")]
    [SerializeField] private float longitudRaycastTierra;
    private bool tocandoTierra;

    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoHorizontal = ObtenerInput().x;
        if (Input.GetButtonDown("Jump"/*Omi esta linea*/))
            Saltando();
    }

    //Aqui empiezan las funciones para el movimiento del personaje
    private void FixedUpdate()
    {
        MovimientoPersonaje();
        AplicarLinearDrag();
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
    }

    private void AplicarLinearDrag() 
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
    //Aqui terminan las funciones para el movimiento del personaje



    //EAqui empiezan las funciones para el salto del personaje
    private void Saltando()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, 0f);
        rb2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }

    private void checarColisiones() 
    {
        tocandoTierra = Physics2D.Raycast(transform.position * longitudRaycastTierra, Vector2.down, longitudRaycastTierra, capaTierra);
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
