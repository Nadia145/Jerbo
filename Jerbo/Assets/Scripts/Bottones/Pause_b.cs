using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_b : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Panel menu pausa
    public GameObject panelPausa;
    public bool estaPausado = false;

    public void Pausar()
    {
        estaPausado = !estaPausado;
        panelPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}