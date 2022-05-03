using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalControl : MonoBehaviour
{
    public int Health;
    public int Headphones;
    public static GlobalControl Instance;
    public GameObject Jerbo1, Jerbo2, Jerbo3, Jerbo4;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(Jerbo1);
            DontDestroyOnLoad(Jerbo2);
            DontDestroyOnLoad(Jerbo3);
            DontDestroyOnLoad(Jerbo4);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeScore(int score)
    {
        Headphones += score;
    }

    void Start()
    {
        Health = 8;
        Jerbo1.gameObject.SetActive(true);
        Jerbo2.gameObject.SetActive(false);
        Jerbo3.gameObject.SetActive(false);
        Jerbo4.gameObject.SetActive(false);
    }

    public void ChangeHealth(int damage)
    {
        Health = Health - damage;
    }

    void Update() {

        if (Health > 8)
            Health = 8;

        switch (Health) {

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
                break;

            case 6:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(true);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(false);
                break;

            case 5:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(true);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(false);
                break;

            case 4:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(true);
                Jerbo4.gameObject.SetActive(false);
                break;

            case 3:
                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(true);
                Jerbo4.gameObject.SetActive(false);
                break;

            case 2:

                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(true);
                break;

            case 1:

                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(true);
                break;


            case 0:

                Jerbo1.gameObject.SetActive(false);
                Jerbo2.gameObject.SetActive(false);
                Jerbo3.gameObject.SetActive(false);
                Jerbo4.gameObject.SetActive(true);
                break;

        }


    }

}
