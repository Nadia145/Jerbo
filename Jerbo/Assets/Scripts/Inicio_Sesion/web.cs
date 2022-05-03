using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Globalization;
using System;

public class web : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // A correct website page.
        //StartCoroutine(GetRequest("http://localhost/UnityBackendTutorial/GetData.php"));
        //StartCoroutine(Login("Yranda","Nova"));
        //StartCoroutine(RegisterUser("Viclinux","linux123"));
        //StartCoroutine(GetUsers());
    }

    // Update is called once per frame
    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    break;
            }
        }
    }

    IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/JerboReto/userscheck.php"))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                byte[] results = www.downloadHandler.data;
            }
        }


    }





    public IEnumerator RegisterUser(string username, string password)
    {

    
        WWWForm form = new WWWForm();

        form.AddField("usuario", username);
        form.AddField("contraseña", password);
        

        
        //protejer variables
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/JerboReto/userscheck.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }



}