using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionesBehaviour : MonoBehaviour
{
    public float flightSpeed;
    public bool chase = false;
    public Transform startingPoint;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (chase)
        {
            Chase();
        }
        else {

            ReturnStartPosition(); 
        }
        Flip();
    }

    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, flightSpeed * Time.deltaTime);
    }

    private void ReturnStartPosition() {

        transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, flightSpeed * Time.deltaTime);
    }


    private void Flip()
    {
        if (transform.position.x > player.transform.position.x)
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }


}
