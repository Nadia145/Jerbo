using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Funcion para entrar a MapaMundo
    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }

    //Funcion para entrar a los Creditos
    public void Credits()
    {
        SceneManager.LoadScene(2);
    }

    //Funcion para quitar el juego
    public void ExitGame()
    {
        //Debug.Log("Se cerro el juego");
        Application.Quit();
    }
}
