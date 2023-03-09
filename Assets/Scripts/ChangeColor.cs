using UnityEngine;
using System.Collections;
using game4automation;

public class ChangeColor : MonoBehaviour
{
    [Header("Factory Interfaces")]
    public OPCUA_Interface[] opcuaInterfaces;
    public float checkInterval = 1f; // 检查间隔时间
    private float lastCheckTime = 0f; // 上次检查的时间


    void Start()
    {

    }

    void Update()
    {
        if (Time.time - lastCheckTime >= checkInterval)
        {
            lastCheckTime = Time.time;

            for (int i = 0; i < opcuaInterfaces.Length; i++)
            {
                GameObject go = opcuaInterfaces[i].gameObject;
                Renderer renderer = go.GetComponent<Renderer>();
                if (opcuaInterfaces[i].IsConnected)
                {
                    renderer.material.color = Color.green;
                }
                else
                {
                    renderer.material.color = Color.red;
                }
            }

        }
    }
    
}
