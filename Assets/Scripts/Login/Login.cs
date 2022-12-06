using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    private TMP_InputField usernameLogin;
    private TMP_InputField passwordLogin;

    public Button loginButton;

    private string _usernameLogin = string.Empty;
    private string _passwordLogin = string.Empty;

    private string DecodePass(string pass)
    {
        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        System.Text.Decoder decoder = encoder.GetDecoder();
        byte[] encoded = Convert.FromBase64String(pass);
        int chars = decoder.GetCharCount(encoded, 0, encoded.Length);
        char[] decoded = new char[chars];
        decoder.GetChars(encoded, 0, encoded.Length, decoded, 0);
        string result = new string(decoded);
        return result;
    }

    void Start()
    {
        usernameLogin = GameObject.Find("Login_Username_InputField").GetComponent<TMP_InputField>();
        passwordLogin = GameObject.Find("Login_Password_InputField").GetComponent<TMP_InputField>();
    }
    void Awake()
    {
        loginButton.onClick.AddListener(loginAccount);
    }
    
    void Update()
    {
        if((usernameLogin != null || passwordLogin != null) && (usernameLogin.isFocused || passwordLogin.isFocused))
        {
            loginButton.GetComponent<Error_Message>().clearError();
        }
    }

    private void loginAccount()
    {
        _usernameLogin = usernameLogin.text;
        _passwordLogin = passwordLogin.text;

        if(!string.IsNullOrEmpty(_usernameLogin) && !string.IsNullOrEmpty(_passwordLogin))
        {
            if(validateUsername())
            {
                if(validatePassword())
                {
                    if(verifyUsername())
                    {
                        if(verifyPassword())
                        {
                            Player_Account.Instance.readData();
                            Debug.Log("Successful Login: " + _usernameLogin + " " + _passwordLogin);
                            SceneManager.LoadScene(1);
                        }
                        else
                        {
                            loginButton.GetComponent<Error_Message>().dispayMessage(0);
                        }
                    }
                    else
                    {
                        loginButton.GetComponent<Error_Message>().dispayMessage(0);
                    }
                }
                else
                {
                    loginButton.GetComponent<Error_Message>().dispayMessage(0);
                }
            }
            else
            {
                loginButton.GetComponent<Error_Message>().dispayMessage(0);
            }
        }
        else
        {
            loginButton.GetComponent<Error_Message>().dispayMessage(1);
        }
    }

    private bool validateUsername()
    {
        string pattern = @"^([a-zA-Z0-9-_]{3,15})$";
        Regex rgx = new Regex(pattern);

        return rgx.IsMatch(_usernameLogin);
    }
    private bool verifyUsername()
    {
        return Player_Account.Instance.verifyAccount(usernameLogin.text);
    }

    private bool validatePassword()
    {
        string pattern = @"^([a-zA-Z0-9\!\@\#\$\%\-_]{5,20})$";
        Regex rgx = new Regex(pattern);

        return rgx.IsMatch(_passwordLogin);
    }
    private bool verifyPassword()
    {
        return Player_Account.Instance.verifyPassword(DecodePass(passwordLogin.text));
    }
}
