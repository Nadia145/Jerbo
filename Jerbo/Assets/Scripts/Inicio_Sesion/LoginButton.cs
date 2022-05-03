using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuInicio()
    {
        SceneManager.LoadScene("Login");
    }
}
