using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using TMPro;
using UnityEngine;

/// <summary> 
/// TCP Client-Server Connection Example.
/// 2 way communication: Client (your app) connects to the server and can send and receive messages.
/// Simply place this script on an empty gameobject in your scene. Note your firewall may need to be disabled.
/// The OrderCompleteNewPhone method is an example of how you could use it. e.g calling it from a UI button.
/// <summary> 

public class SendOrder : MonoBehaviour
{
	#region private members 	
	private TcpClient socketConnection;
	private Thread clientReceiveThread;
	#endregion

	#region public members 	

	// Address of the server PC connected to the Festo machine. This should not need to be changed.
	public string serverAddress = "172.21.0.90";

	// Example of a message to send to the MES server.
	// This message places a new order of the complete mobile phone (known as part number 210). See documentation on Canvas for full breakdown of how this string is formatted.
	// Additional part numbers can be found on the Festo PC.   

	public string partNumber;
	public int qty;
    public TMP_InputField inputField;
    public string newOrderMessage;
	public TMP_Text output;
	public TMP_Text feedbackText;
	#endregion




	// Use this for initialization 	
	void Start()
	{
		ConnectToTcpServer();
	}

	/// <summary> 	
	/// Setup socket connection. 	
	/// </summary> 	
	private void ConnectToTcpServer()
	{
		try
		{
			clientReceiveThread = new Thread(new ThreadStart(ListenForData));
			clientReceiveThread.IsBackground = true;
			clientReceiveThread.Start();
		}
		catch (Exception e)
		{
			Debug.Log("On client connect exception " + e);
		}
	}
	/// <summary> 	
	/// Runs in background clientReceiveThread; Listens for incoming data. 	
	/// </summary>     
	private void ListenForData()
	{
		try
		{
			socketConnection = new TcpClient(serverAddress, 2000);
			Byte[] bytes = new Byte[1024];
			while (true)
			{
				// Get a stream object for reading 				
				using (NetworkStream stream = socketConnection.GetStream())
				{
					int length;
					// Read incoming stream into byte arrary. 					
					while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						var incomingData = new byte[length];
						Array.Copy(bytes, 0, incomingData, 0, length);
						// Convert byte array to string message. 						
						string serverMessage = Encoding.ASCII.GetString(incomingData);						
						
						// this is the message the MES server sends back. Its formatting is the same as the message you send to it. 
						Debug.Log("Server message received as: " + serverMessage);
					}
				}
			}
		}
		catch (SocketException socketException)
		{
			Debug.Log("Socket exception: " + socketException);
		}
	}
	/// <summary> 	
	/// Send message to server using socket connection. 	
	/// </summary> 	
	private void SendMessageToServer(string message)
	{
		if (socketConnection == null)
		{
			return;
		}
		try
		{
			// Get a stream object for writing. 			
			NetworkStream stream = socketConnection.GetStream();
			if (stream.CanWrite)
			{
				string clientMessage = message;
				// Convert string message to byte array.                 
				byte[] clientMessageAsByteArray = Encoding.ASCII.GetBytes(clientMessage);
				// Write byte array to socketConnection stream.                 
				stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
				Debug.Log("Message has been sent by client - should be received by server");
			}
		}
		catch (SocketException socketException)
		{
			Debug.Log("Socket exception: " + socketException);
		}
	}

	public void Item210()
	{
		partNumber = "210";
        output.text = "Order Number: " + partNumber;
    }

    public void Item214()
    {
        partNumber = "214";
        output.text = "Order Number: " + partNumber;
    }

    public void Item1200()
    {
        partNumber = "1200";
		output.text = "Order Number: " + partNumber;
    }

    public void Item1201()
    {
        partNumber = "1201";
        output.text = "Order Number: " + partNumber;
    }

    public void Item1210()
    {
        partNumber = "1210";
        output.text = "Order Number: " + partNumber;
    }

    public void Item3001()
    {
        partNumber = "3001";
        output.text = "Order Number: " + partNumber;
    }

    public void Item3002()
    {
        partNumber = "3002";
        output.text = "Order Number: " + partNumber;
    }

    public void Item3003()
    {
        partNumber = "3003";
        output.text = "Order Number: " + partNumber;
    }

    public void Item3005()
    {
        partNumber = "3005";
        output.text = "Order Number: " + partNumber;
    }
    /// <summary> 
    // Call this method from somewhere in your app to place a new order
    /// <summary> 
    public void SendOrderToFactory()
	{
		if (int.TryParse(inputField.text, out qty))
		{
			newOrderMessage = "444;RequestID=0;MClass=101;MNo=2;ErrorState=0;#PNo= " + partNumber + ";#Aux1Int=" + qty.ToString() + "\r";
			SendMessageToServer(newOrderMessage);
			feedbackText.text = "Successful Ordered: " + "\r\n" + partNumber + ". Qty: " + qty.ToString();
		}
        else
        {
            feedbackText.text = "Invalid quantity value: " + inputField.text;
        }
    }

  //  private void Update()
  //  {
  //      if(Input.GetKey(KeyCode.Space))
  //      {
		//	OrderCompleteNewPhone();
		//}
  //  }
}