using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clicker2 : MonoBehaviour
{
    public bool Click3 = false;
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
        Click3 = true;
        Debug.Log("Третий элемент нажат");
    }


}
