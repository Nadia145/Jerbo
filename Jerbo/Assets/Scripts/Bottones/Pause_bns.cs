using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Omar*/

public class Pause_bns : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene(1/*Index de MainMenu*/);
    }
    public void goMap()
    {
        SceneManager.LoadScene(2/*Index de MainMenu*/);
    }

    //Hay que modificar este de aqui 
    public void Continue() 
    {
        SceneManager.LoadScene(3/*Index de MainMenu*/);
    }
}
