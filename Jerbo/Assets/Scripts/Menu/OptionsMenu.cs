using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
/*Nadia*/
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void OpcionesVolumen(float volumen) 
    {
        audioMixer.SetFloat("VolumenMenu", volumen);
    }
}
