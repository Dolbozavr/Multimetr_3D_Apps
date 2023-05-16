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
    [SerializeField]
    private LeftClemmaRozetki leftClemmaRozetki;
    [SerializeField]
    private RightClemmaRozetki rightClemmaRozetki;
    private Vector3 basepos;
    private bool Click;
    [SerializeField]
    private Animation animat;
    public bool ConnectToRightClemma=false;
    public bool ConnectToLeftClemma = false;
    public bool ConnectToRightClemmaRozetki = false;
    public bool ConnectToLeftClemmaRozetki = false;
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
        if (Click == true && leftClemmaRozetki.ClickLeftClemmaRozetka)
        {
            ConnectToLeftClemmaRozetki = true;
            animat.Play("BlackProbeLeftRozetkaStart");
            Click = false;
            leftClemmaRozetki.ClickLeftClemmaRozetka = false;
        }
        if (Click == true && rightClemmaRozetki.ClickRightClemmaRozetka)
        {
            ConnectToRightClemmaRozetki = true;
            animat.Play("BlackProbeRightRozetkaStart");
            Click = false;
            rightClemmaRozetki.ClickRightClemmaRozetka = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(12.46f, 2.53f, 0.843f))
        {
            ConnectToLeftClemma = false;
            animat.Play("BlackProbeLeftBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(12.47f, 2.592f, -0.294f))
        {
            ConnectToRightClemma = false;
            animat.Play("BlackProbeBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(2.639f, 1.283f, -4.175f))
        {
            ConnectToLeftClemmaRozetki = false;
            animat.Play("BlackProbeLeftRozetkaBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(1.366f, 1.294f, -4.172f))
        {
            ConnectToRightClemmaRozetki = false;
            animat.Play("BlackProbeRightRozetkaBack");
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
