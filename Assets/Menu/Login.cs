using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{


    public InputField username;
    public InputField password;

    private string loginURL = "http://skegogo.esy.es/Login.php";

    public void login()
    {
        StartCoroutine(LoginToDB(username.text, password.text));
    }

    IEnumerator LoginToDB(string user, string pass)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", user);
        form.AddField("passwordPost", pass);
        WWW www = new WWW(loginURL, form);
        yield return www;
        Debug.Log(www.text);
    }
}
