using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonUI : MonoBehaviour
{
    public bool clickRedButton = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        clickRedButton = true;
    }
}
