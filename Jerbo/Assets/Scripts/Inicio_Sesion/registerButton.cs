using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class registerButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuInicio()
    {
        SceneManager.LoadScene("Register");
    }
}
