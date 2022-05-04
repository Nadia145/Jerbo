using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omar : MonoBehaviour
{
    public float speed;
    private Transform player;
    public float ShootingRange;
    public float FireRate = 4f;
    private float nextFireTime;
    public GameObject bullet;
    public GameObject bulletParent;
    private AudioSource Buubuuu;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Buubuuu = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer > ShootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= ShootingRange && nextFireTime <Time.time) {

            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            Buubuuu.Play();
            nextFireTime = Time.time + FireRate;
        
        }

    }
}
