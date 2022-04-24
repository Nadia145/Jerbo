using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Omar*/
public class Exit_b : MonoBehaviour
{
    //funcion para regresar al menu principl
    public void Exit()
    {
        SceneManager.LoadScene(1/*Index de MainMenu*/);
    }
}