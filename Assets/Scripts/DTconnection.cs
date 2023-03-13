using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DTconnection : MonoBehaviour
{
    public TMP_Text factory;
    public TMP_Text robotArm;
    public TMP_Text cameraStation;
    public TMP_Text branch;
    public TMP_Text frontMagazine;
    public TMP_Text measuring;
    public TMP_Text drilling;
    public TMP_Text backMagazine;
    public TMP_Text pressing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CFactory()
    {
        factory.text = "Good Connection";
    }

    public void DCFactory()
    {
        factory.text = "No Connection";
    }

    public void CRobotArm()
    {
        robotArm.text = "Good Connection";
    }

    public void DCRobotArm()
    {
        robotArm.text = "No Connection";
    }

    public void CcameraStation()
    {
        cameraStation.text = "Good Connection";
    }

    public void DCcameraStation()
    {
        cameraStation.text = "No Connection";
    }

    public void Cbranch()
    {
        branch.text = "Good Connection";
    }

    public void DCbranch()
    {
        branch.text = "No Connection";
    }

    public void CfrontMagazine()
    {
        frontMagazine.text = "Good Connection";
    }

    public void DCfrontMagazine()
    {
        frontMagazine.text = "No Connection";
    }

    public void Cmeasuring()
    {
        measuring.text = "Good Connection";
    }

    public void DCmeasuring()
    {
        measuring.text = "No Connection";
    }

    public void Cdrilling()
    {
        drilling.text = "Good Connection";
    }

    public void DCdrilling()
    {
        drilling.text = "No Connection";
    }

    public void CbackMagazine()
    {
        backMagazine.text = "Good Connection";
    }

    public void DCbackMagazine()
    {
        backMagazine.text = "No Connection";
    }

    public void Cpressing()
    {
        pressing.text = "Good Connection";
    }

    public void DCpressing()
    {
        pressing.text = "No Connection";
    }
}
