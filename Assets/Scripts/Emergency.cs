using game4automation;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Emergency : MonoBehaviour
{

    [Header("Factory Machine")]
    public string factoryMachineID;
    public OPCUA_Interface Interface;


    [Header("OPCUA Reader")]
    public string nodeBeingMonitored;
    public string nodeID;

    //public TMP_Text digitalTwinFeedbackTMP;
    public GameObject _objectToChangeColour;
    public string dataFromOPCUANode;

    public Material _connectedMaterial;

    public Material _disconnectedMaterial;
    void Start()
    {
        Interface.EventOnConnected.AddListener(OnInterfaceConnected);
        Interface.EventOnConnected.AddListener(OnInterfaceDisconnected);
        Interface.EventOnConnected.AddListener(OnInterfaceReconnect);
    }


    private void OnInterfaceConnected()
    {
        Debug.LogWarning("Connected to Factory Machine " + factoryMachineID);
        var subscription = Interface.Subscribe(nodeID, NodeChanged);
        dataFromOPCUANode = subscription.ToString();
        Debug.Log(dataFromOPCUANode);
        //digitalTwinRFIDFeedbackTMP.text = RFIDInfo;
        //uiRFIDFeedbackTMP.text = RFIDInfo;        
    }

    private void OnInterfaceDisconnected()
    {
        Debug.LogWarning("Factory Machine " + factoryMachineID + " has disconnected");
    }

    private void OnInterfaceReconnect()
    {
        Debug.LogWarning("Factory Machine " + factoryMachineID + " has reconnected");
    }

    public void NodeChanged(OPCUANodeSubscription sub, object value)
    {
        dataFromOPCUANode = value.ToString();
        Debug.Log(dataFromOPCUANode);
    }


    private void Update()
    {
        if(dataFromOPCUANode.Equals("True"))
        {
            _objectToChangeColour.GetComponent<MeshRenderer>().material = _connectedMaterial;
        }
        else
        {
            _objectToChangeColour.GetComponent<MeshRenderer>().material = _disconnectedMaterial;
        }
    }
}
