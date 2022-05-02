using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip playerHitSound, Scream, Scream2;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    { 
       switch (clip){
            case "Scream":
                audioSrc.PlayOneShot(Scream);
                break;
            case "Scream2":
                audioSrc.PlayOneShot(Scream2);
                break;
            case "playerHit":
                audioSrc.PlayOneShot(playerHitSound);
                break;

        }
    }
}
