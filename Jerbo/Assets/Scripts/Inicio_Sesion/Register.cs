using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Register : MonoBehaviour
{
    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public Button RegisterButton;



    // Start is called before the first frame update
    void Start()
    {
        RegisterButton.onClick.AddListener(() =>
        {

            StartCoroutine(Main.Instance.Web.RegisterUser(UsernameInput.text, PasswordInput.text));
        });


        //Main.Instance.Web.RegisterUser()
    }


}
