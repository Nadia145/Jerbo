using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerHitSound, EnemyShoutSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        EnemyShoutSound = Resources.Load<AudioClip>("ScreamSchool");
        playerHitSound = Resources.Load<AudioClip>("Squeak 1");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip) {
            case "Scream":
                audioSrc.PlayOneShot(EnemyShoutSound);
                break;
            case "Ouch":
                audioSrc.PlayOneShot(playerHitSound);
                break;
        
        
        
        
        }
    
    }

}
