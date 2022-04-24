using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Esc_b : MonoBehaviour
{
    [SerializeField]
    private bool gameRunning;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeGameRunningState();
        }
    }
    public void ChangeGameRunningState(){
        gameRunning=!gameRunning;
        if(gameRunning){
            Debug.Log("GameRunning");
        }else{
            Debug.Log("Game Paused");

        }
    }
    public bool IsgameRunning()
    {
        return gameRunning;
    }
}
