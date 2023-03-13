using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnConnectColourChange : MonoBehaviour
{
    public GameObject _objectToChangeColour;

    public Material _connectedMaterial;

    public Material _disconnectedMaterial;

    private void Start()
    {
        InterfaceDisconnected();
    }

    public void InterfaceConnected()
    {
        _objectToChangeColour.GetComponent<MeshRenderer>().material = _connectedMaterial;
    }

    public void InterfaceDisconnected()
    {
        _objectToChangeColour.GetComponent<MeshRenderer>().material = _disconnectedMaterial;
    }


}

