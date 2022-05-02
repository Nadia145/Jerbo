using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinoRaro : MonoBehaviour
{
    public int health;
    public float speed;

    public GameObject BloodEffect;

    public bool FindPlayer;

    public Animator enemyAnim;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void GiveDamage()
    {
        if (FindPlayer)
        {
            //Damage
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.name == "Player")//or tag
            {
                //biu
            }

        }
    }
}