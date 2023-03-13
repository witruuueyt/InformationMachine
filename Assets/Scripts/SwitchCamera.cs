using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject  camera1;
    public GameObject  arcamera;
    public bool armode;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void modeSwitch()
    {
        if(armode == true)
        {
            camera1.SetActive(false);
            arcamera.SetActive(true);
            armode= false;
        }
        else
        {
            arcamera.SetActive(false);
            camera1.SetActive(true);
            armode= true;
        }
    }
}
