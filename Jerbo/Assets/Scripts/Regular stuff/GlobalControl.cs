using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalControl : MonoBehaviour
{
    public int HealthMax = 8;
    public static int PlayerHealth = 8;
    public int Headphones;
    public static GlobalControl Instance;
    public GameObject Jerbo1, Jerbo2, Jerbo3, Jerbo4;
    private AudioSource Squeak;


    public void ChangeScore(int score)
    {
        Headphones += score;
    }

    void Start()
    {
        Squeak = GetComponent<AudioSource>();
    }

    public static void ChangeHealth(int damage)
    {
        PlayerHealth = PlayerHealth - damage;

    }

    void Update() {

        if (PlayerHealth > 8)
            PlayerHealth = 8;

        switch (PlayerHealth) {

            case 8:
                Jerbo1.gameObject.SetActive(true);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(false);
                break;

            case 7:
                Jerbo1.gameObject.SetActive(true);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(false);
                Squeak.Play();
                break;

            case 6:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(true);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(false);
                Squeak.Play();
                break;

            case 5:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(true);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(false);
                Squeak.Play();
                break;

            case 4:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(true);
                Jerbo4.gameObject.SetActive(false);
                Squeak.Play();
                break;

            case 3:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(true);
                Jerbo4.gameObject.SetActive(false);
                Squeak.Play();
                break;

            case 2:

                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(true);
                Squeak.Play();
                break;

            case 1:

                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(true);
                Squeak.Play();
                break;


            case 0:

                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(true);
                Squeak.Play();
                break;

        }


    }

}
