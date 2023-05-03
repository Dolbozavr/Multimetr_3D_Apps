using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedProbeScript : MonoBehaviour
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
    public bool ConnectToRightClemma = false;
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
            ConnectToRightClemma = true;
            animat.Play("RedProbeStart");
            Click = false;
            rightClemmaPribora.ClickRightClemma = false;
        }
        if (Click == true && leftClemmaPribora.ClickLeftClemma)
        {
            ConnectToLeftClemma = true;
            animat.Play("RedProbeLeftStart");
            Click = false;
            leftClemmaPribora.ClickLeftClemma = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(70.734f, -67.274f, -94.286f))
        {
            ConnectToLeftClemma = false;
            animat.Play("RedProbeLeftBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(69.07f, -67.278f, -94.29f))
        {
            ConnectToRightClemma = false;
            animat.Play("RedProbeBack");
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
    public void RedProbeVoid(Action on_change)
    {
        onChange = on_change;
    }
}
