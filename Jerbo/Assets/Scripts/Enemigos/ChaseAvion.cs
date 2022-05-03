using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAvion : MonoBehaviour
{
    public AvionesBehaviour[] enemyArray;

     void OntriggerEnter2D(Collider2D Collision) {

        if (Collision.CompareTag("Player"))
        {
            foreach (AvionesBehaviour enemy in enemyArray)
            {
                enemy.chase = true;
            }
        
        }

     void OnTriggerExit2D(Collider2D Collision) {

            if (Collision.CompareTag("Player")) { 
            
                foreach(AvionesBehaviour enemy in enemyArray)
                {
                    enemy.chase = false;
                }
            } 
        
        }
    
    
    }
}
