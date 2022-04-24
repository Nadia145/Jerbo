using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;
using UnityEngine.Networking;

public class web : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    public IEnumerator RegisterUser(string username, string password)
    {
        DateTime fecha = DateTime.Now;
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        //protejer variables
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityBackendTutorial/registerUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("New user created");
            }
        }
    }
}
