using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Create_New_Account : MonoBehaviour
{
    private TMP_InputField usernameCreate;
    private TMP_InputField passwordCreate;
    private TMP_InputField passwordConfirm;

    public Button createButton;

    private string username = string.Empty;
    private string password = string.Empty;
    private string confirmPassword = string.Empty;

    void Start()
    {
        usernameCreate = GameObject.Find("Create_Username_InputField").GetComponent<TMP_InputField>();
        passwordCreate = GameObject.Find("Create_Password_InputField").GetComponent<TMP_InputField>();
        passwordConfirm = GameObject.Find("Create_Password_Confirm_InputField").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Awake()
    {
        createButton.onClick.AddListener(createAccount);
    }

    private void createAccount()
    {
        username = usernameCreate.text;
        password = passwordCreate.text;
        confirmPassword = passwordConfirm.text;

        if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
        {
            Debug.Log(username + " " + password + " " + confirmPassword);
        }
    }
    
    private bool validateUsername()
    {
        return false;
    }
    private bool verifyUsername()
    {
        return false;
    }

    private bool validatePassword()
    {
        return false;
    }
    private bool confirmPasswordEntry()
    {
        return false;
    }
}
