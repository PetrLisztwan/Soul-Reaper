//using Mono.Data.Sqlite;
//using System.Data;
//using System.Data.SQLite;
using System.Text.RegularExpressions;
using TMPro;
//using UnityEditor.Search;
using UnityEngine;
public class UIScript : MonoBehaviour
{
    public TMP_InputField Username;
    public TMP_InputField Password;
    public bool Passed = false;
    private Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[^\s<>]{8,}$");

    public void Enter()
    {
        if (Username.text.Length > 2 && Username.text.Length < 21)
        {
            Debug.Log(Username.text);
            Debug.Log("Username passed requirement check");
            if (passwordRegex.IsMatch(Password.text)) {
                Debug.Log(Password.text);
                Debug.Log("Password passed requirement check");
                Passed = true;
          
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

        /*if (Passed == true) {

            string conn = "Data Source=C:\\Users\\s241236\\OneDrive - Greenhead College\\CS Programming\\MasterDatabase.db;Version=3;";
            using (var connection = new SQLiteConnection(conn))
            { 
                connection.Open();
                using (var command = connection.CreateCommand()) {
                { 
                        command.CommandText = "INSERT INTO Users (Username, Password) VALUES (@user, @pass)";
                        command.ExecuteNonQuery();

                }
            }
        */}
    }



