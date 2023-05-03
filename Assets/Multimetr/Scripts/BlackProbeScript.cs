using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackProbeScript : MonoBehaviour
{
    private Action onChange;
    [SerializeField]
    private RightClemmaPribora rightClemmaPribora;
    [SerializeField]
    private LeftClemmaPribora leftClemmaPribora;
    private Vector3 basepos;
    private bool Click;
    [SerializeField]
    private Animation animat;
    public bool ConnectToRightClemma=false;
    public bool ConnectToLeftClemma = false;
    // Start is called before the first frame update
    void Start()
    {
        rightClemmaPribora.ClickRightclemma(Update);
        basepos = gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Click == true && rightClemmaPribora.ClickRightClemma)
        {
            animat.Play("BlackProbeStart");
            ConnectToRightClemma=true;
            Click = false;
            rightClemmaPribora.ClickRightClemma= false;
        }
        if (Click == true && leftClemmaPribora.ClickLeftClemma)
        {
            animat.Play("BlackProbeLeftStart");
            ConnectToLeftClemma = true;
            Click = false;
            leftClemmaPribora.ClickLeftClemma = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(14.12f, 2.221f, -0.152f))
        {
            ConnectToLeftClemma = false;
            animat.Play("BlackProbeLeftBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(12.48f, 2.23f, -0.087f))
        {
            ConnectToRightClemma = false;
            animat.Play("BlackProbeBack");
            Click = false;
        }
        if (onChange != null)
        {
            onChange();
        }
    }
    private void OnMouseDown()
    { 
        Click = true;
        Debug.Log("Первый элемент нажат");
    }
    public void BlackProbeVoid(Action on_change)
    {
        onChange = on_change;
    }
}
