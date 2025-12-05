using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class UIScript : MonoBehaviour
{
    public TMP_InputField Username;
    public TMP_InputField Password;


    private Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[^\s<>]{8,}$");
    //private bool Passed = false;


    public void Enter()
    {
        if (Username.text.Length > 2 && Username.text.Length < 21)
        {
            Debug.Log(Username.text);
            Debug.Log("Username passed requirement check");
            if (passwordRegex.IsMatch(Password.text)) {
                Debug.Log(Password.text);
                Debug.Log("Password passed requirement check");
              
                //Passed = true;
            }
            else
            {
                Debug.Log(Password.text);
                Debug.Log("Password failed requirement check");
            }
        }
        else
        {
            Debug.Log(Username.text);
            Debug.Log("Username failed requirement check");
        }
    }
}