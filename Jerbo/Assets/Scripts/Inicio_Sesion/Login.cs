using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public Button LoginButton;

    // Update is called once per frame
    void Start()
    {
        LoginButton.onClick.AddListener(() =>
        {

            StartCoroutine(Main.Instance.Web.LoginUser(UsernameInput.text, PasswordInput.text));


        });
    }

}
