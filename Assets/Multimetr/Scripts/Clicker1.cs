using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker1 : MonoBehaviour
{
    public bool Click2=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Click2 = true;
        Debug.Log("Второй элемент нажат");
    }
}
