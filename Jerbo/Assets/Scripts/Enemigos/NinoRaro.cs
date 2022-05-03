using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinoRaro : MonoBehaviour
{
    public float TimeforScream = 10;
    public bool Screamisgoing = false;
    private AudioSource Aaaaa;


    // Start is called before the first frame update
    void Start()
    {
        Screamisgoing = true;
        Aaaaa = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Screamisgoing)
        {
            if (TimeforScream > 0)
            {
                TimeforScream -= Time.deltaTime;
            }
            else
            {
                Aaaaa.Play();
                TimeforScream = 10;
                Screamisgoing = true;
                if (PlayerMovement.Agachado == false) {
                    GlobalControl.ChangeHealth(1);
                }
           
            }
        
        
        
        }
    }
}
