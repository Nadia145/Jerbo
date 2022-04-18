using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Omar*/
public class WorldMap : MonoBehaviour
{
    //funcion para regresar al menu principál
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex/*Index de MainMenu*/);
    }
    /*Funcion q regresa inicia animaciones*/
    public void Z_0()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex/*Index de "Hogar"(Agragar animaciones a esta escena)*/);
    }
    //Funcion que inicia el nivel 1
    public void Z_1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex/*Index de escena de la zona 1(Primer nivel)*/);
    }
    //Funcion que inicia el nivel 2
    public void Z_2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex/*Index de escena de la zona 2(segundo nivel)*/);
    }
    //Funcion que inicia el nivel 3
    public void Z_3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex/*Index de escena de la zona 3(Tercer nivel)*/);
    }
}
