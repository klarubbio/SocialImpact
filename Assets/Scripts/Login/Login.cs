using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    private TMP_InputField usernameLogin;
    private TMP_InputField passwordLogin;

    public Button loginButton;

    private string _usernameLogin = string.Empty;
    private string _passwordLogin = string.Empty;

    void Start()
    {
        usernameLogin = GameObject.Find("Login_Username_InputField").GetComponent<TMP_InputField>();
        passwordLogin = GameObject.Find("Login_Password_InputField").GetComponent<TMP_InputField>();

        if(usernameLogin == null || passwordLogin == null)
        {
            Debug.Log("Missing Usename");
        }
    }
    void Awake()
    {
        loginButton.onClick.AddListener(loginAccount);
    }

    private void loginAccount()
    {
        _usernameLogin = usernameLogin.text;
        _passwordLogin = passwordLogin.text;

        if(!string.IsNullOrEmpty(_usernameLogin) && !string.IsNullOrEmpty(_passwordLogin))
        {
            Debug.Log(_usernameLogin + " " + _passwordLogin);
        }
    }
}
