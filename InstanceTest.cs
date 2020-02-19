using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceTest : MonoBehaviour
{
    public static InstanceTest instance;

    public delegate void InstanceTestCallBack(string message);
    public InstanceTestCallBack callbackTest;

    private void Awake()
    {
        InstanceTest.instance = this;
    }

    public void testLog()
    {
        Debug.Log("hi");
    }

    void Update()
    {
        //Press any other key to begin the action if the Event exists
        if (Input.anyKeyDown)
        {
            //Begin the action
            callbackTest("hi2");
        }
    }
}
