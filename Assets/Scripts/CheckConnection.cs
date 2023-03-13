using UnityEngine;
using game4automation;
using TMPro;



public class CheckConnection : MonoBehaviour
{
    [Header("Factory Interfaces")]
    public OPCUA_Interface[] opcuaInterfaces;
    public TMP_Text feedbackText;
    
    string string1 = "";

    private void Start()
    {
        CheckConnectionWithMachines();
    }
    //runs through all of the factory interfaces checking for connection
    public void CheckConnectionWithMachines()
    {
        feedbackText.SetText(string1); //rewrite message to nothing

        for (int i = 0; i < opcuaInterfaces.Length; i++)             
        {
            
            if (opcuaInterfaces[i].IsConnected)               
            {
                switch (i)
                {
                    case 0:
                        feedbackText.text = feedbackText.text + "Good connection to Factory " + "." + "\r\n";
                        break;

                    case 1:
                        feedbackText.text = feedbackText.text + "Good connection to Robot Arm " + "." + "\r\n";
                        break;

                    case 2:
                        feedbackText.text = feedbackText.text + "Good connection to Camera Station " + "." + "\r\n";
                        break;

                    case 3:
                        feedbackText.text = feedbackText.text + "Good connection to Branch " + "." + "\r\n";
                        break;

                    case 4:
                        feedbackText.text = feedbackText.text + "Good connection to Front Magazine " + "." + "\r\n";
                        break;

                    case 5:
                        feedbackText.text = feedbackText.text + "Good connection to Measuring " + "." + "\r\n";
                        break;

                    case 6:
                        feedbackText.text = feedbackText.text + "Good connection to Drilling " + "." + "\r\n";
                        break;

                    case 7:
                        feedbackText.text = feedbackText.text + "Good connection to Back Magazine " + "." + "\r\n";
                        break;

                    case 8:
                        feedbackText.text = feedbackText.text + "Good connection to Pressing " + "." + "\r\n";
                        break;

                }
            }
            else                                     
            {
                switch (i)
                {
                    case 0:
                        feedbackText.text = feedbackText.text + "No connection to Factory " + "." + "\r\n";
                        break;

                    case 1:
                        feedbackText.text = feedbackText.text + "No connection to Robot Arm " + "." + "\r\n";
                        break;

                    case 2:
                        feedbackText.text = feedbackText.text + "No connection to Camera Station " + "." + "\r\n";
                        break;

                    case 3:
                        feedbackText.text = feedbackText.text + "No connection to Branch " + "." + "\r\n";
                        break;

                    case 4:
                        feedbackText.text = feedbackText.text + "No connection to Front Magazine " + "." + "\r\n";
                        break;

                    case 5:
                        feedbackText.text = feedbackText.text + "No connection to Measuring " + "." + "\r\n";
                        break;

                    case 6:
                        feedbackText.text = feedbackText.text + "No connection to Drilling " + "." + "\r\n";
                        break;

                    case 7:
                        feedbackText.text = feedbackText.text + "No connection to Back Magazine " + "." + "\r\n";
                        break;

                    case 8:
                        feedbackText.text = feedbackText.text + "No connection to Pressing " + "." + "\r\n";
                        break;
                }    
            }
        }
    }
}
