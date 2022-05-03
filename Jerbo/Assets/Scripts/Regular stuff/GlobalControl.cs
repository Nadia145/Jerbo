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
        Health = 50;
        Jerbo1.gameObject.SetActive(true);
        Jerbo2.gameObject.SetActive(false);
        Jerbo3.gameObject.SetActive(false);
        Jerbo4.gameObject.SetActive(false);
    }

    void Update() {

        if (Health > 100)
            Health = 100;

        if (Health == 100 || Health > 75) {
            Jerbo1.gameObject.SetActive(true);
            Jerbo2.gameObject.SetActive(false);
            Jerbo3.gameObject.SetActive(false);
            Jerbo4.gameObject.SetActive(false);
        }

        if (Health == 75 || Health > 50)
        {
            Jerbo1.gameObject.SetActive(false);
            Jerbo2.gameObject.SetActive(true);
            Jerbo3.gameObject.SetActive(false);
            Jerbo4.gameObject.SetActive(false);
        }

        if (Health == 50 || Health > 25) {
            Jerbo1.gameObject.SetActive(false);
            Jerbo2.gameObject.SetActive(false);
            Jerbo3.gameObject.SetActive(true);
            Jerbo4.gameObject.SetActive(false);
        }

        if (Health < 25) {
            Jerbo1.gameObject.SetActive(false);
            Jerbo2.gameObject.SetActive(false);
            Jerbo3.gameObject.SetActive(false);
            Jerbo4.gameObject.SetActive(true);
        }






    }

}
