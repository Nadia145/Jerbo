using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public static HealthController instance;
    public GameObject Jerbo1, Jerbo2, Jerbo3, Jerbo4;
    public int HealthSystem;
    // Start is called before the first frame update
    void Start()
    {
        HealthSystem = 8;
        Jerbo1.gameObject.SetActive(true);
        Jerbo2.gameObject.SetActive(false);
        Jerbo3.gameObject.SetActive(false);
        Jerbo4.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Update()
    {

        }


        public void ChangeSprite(int HealthPoints)
        {
            if (HealthPoints > 8)
                HealthPoints = 8;

        switch (HealthPoints)
            {

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

