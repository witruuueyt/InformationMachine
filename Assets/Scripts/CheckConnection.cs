using UnityEngine;
using game4automation;
using TMPro;



public class CheckConnection : MonoBehaviour
{
    [Header("Factory Interfaces")]
    public OPCUA_Interface[] opcuaInterfaces;
    public TMP_Text feedbackText;
    string string1 = "";
    
    //runs through all of the factory interfaces checking for connection
    public void CheckConnectionWithMachines()
    {
        feedbackText.SetText(string1); //rewrite message to nothing

        for (int i = 0; i < opcuaInterfaces.Length; i++)             
        {
            
            if (opcuaInterfaces[i].IsConnected)               
            {
                feedbackText.text = feedbackText.text + "Good connection to interface " + i + "." + "\r\n"; //println
                Debug.Log("Good connection to interface " + i + ".");
            }
            else                                     
            {
                feedbackText.text = feedbackText.text + "No connection to interface " + i + "." + "\r\n"; //println
                Debug.Log("No connection to interface " + i + ".");
            }
        }
    }
}
