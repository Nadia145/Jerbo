using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Omar*/
public class MenuInicio : MonoBehaviour
{
    public void Login_b()
    {
        SceneManager.LoadScene(7);
    }
    public void Regis_b()
    {
        SceneManager.LoadScene(0);
    }
    public void Login_b_Start()
    {
        SceneManager.LoadScene(1);
    }
    public void Regis_b_Strart()
    {
        SceneManager.LoadScene(1);
    }
    public void Back(){
        SceneManager.LoadScene(8);
    }
}