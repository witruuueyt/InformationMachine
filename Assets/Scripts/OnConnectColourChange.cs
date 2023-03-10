using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolumetricLines;

public class OnConnectColourChange : MonoBehaviour
{
    public GameObject _objectToChangeColour;

    public Color _connectedColor = Color.green;

    public Color _disconnectedColor = Color.red;

    private Material _material;


    private void Start()
    {
        _material = _objectToChangeColour.GetComponent<VolumetricLineBehavior>().TemplateMaterial;
        InterfaceDisconnected();
    }

    public void InterfaceConnected()
    {
        _material.color = _connectedColor;
    }

    public void InterfaceDisconnected()
    {
        _material.color = _disconnectedColor;
    }
}

