using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

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
    void Update()
    {
        if(usernameCreate != null && passwordCreate != null && passwordConfirm != null)
        {
            if(usernameCreate.isFocused || passwordCreate.isFocused || passwordConfirm.isFocused)
            {
                createButton.GetComponent<Error_Message>().clearError();
            }
        }
    }

    private void createAccount()
    {
        username = usernameCreate.text;
        password = passwordCreate.text;
        confirmPassword = passwordConfirm.text;

        if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
        {
            if(validateUsername())
            {
                if(validatePassword())
                {
                    if(confirmPasswordEntry())
                    {
                        if(verifyUsername())
                        {
                            Player_Account.Instance.createAccount(username, password);
                            Debug.Log(username + " " + password + " " + confirmPassword);
                            SceneManager.LoadScene(1);
                        }
                        else
                        {
                            //username already exists
                            createButton.GetComponent<Error_Message>().dispayMessage(2);
                        }
                    }
                    else
                    {
                        // passwords dont match
                        createButton.GetComponent<Error_Message>().dispayMessage(1);
                    }
                }
                else
                {
                    // invalid password
                    createButton.GetComponent<Error_Message>().dispayMessage(0);
                }
            }
            else
            {
                //invalid username
                createButton.GetComponent<Error_Message>().dispayMessage(0);
            }
        }
        else
        {
            createButton.GetComponent<Error_Message>().dispayMessage(3);
        }
    }
    
    private bool validateUsername()
    {
        string pattern = @"^([a-zA-Z0-9-_]{3,15})$";
        Regex rgx = new Regex(pattern);

        return rgx.IsMatch(username);
    }
    private bool verifyUsername()
    {
        return !(Player_Account.Instance.verifyAccount(username));
    }

    private bool validatePassword()
    {
        string pattern = @"^([a-zA-Z0-9\!\@\#\$\%\-_]{5,20})$";
        Regex rgx = new Regex(pattern);

        return rgx.IsMatch(password);;
    }
    private bool confirmPasswordEntry()
    {
        string pattern = @"^(" + password + ")$";
        Regex rgx = new Regex(pattern);

        return rgx.IsMatch(confirmPassword);
    }
}
