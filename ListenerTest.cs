using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListenerTest : MonoBehaviour
{
    private void Start()
    {
        InstanceTest.instance.testLog();
        InstanceTest.instance.callbackTest += DelFunction;
    }

    public void DelFunction(string str)
    {
        Debug.Log("test : " + str);
    }

    void Update()
    {
        /*
        //Press any other key to begin the action if the Event exists
        if (Input.anyKeyDown)
        {
            //Begin the action
            
        }
        */
    }
}
