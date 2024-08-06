using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshCreator : MonoBehaviour
{
    [DllImport("UnityCPPFunctions")]
    private static extern float AddTwoFloats(float x, float y);

    public int xSize, ySize;

    // Start is called before the first frame update
    void Start()
    {
        float myFloat = AddTwoFloats(2.5f, 4.1f);
        Debug.Log("myFloat = " + myFloat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
