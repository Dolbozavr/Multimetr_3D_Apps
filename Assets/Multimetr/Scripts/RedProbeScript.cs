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
    [SerializeField]
    private LeftClemmaRozetki leftClemmaRozetki;
    [SerializeField]
    private RightClemmaRozetki rightClemmaRozetki;
    private Vector3 basepos;
    private bool Click;
    [SerializeField]
    private Animation animat;
    public bool ConnectToRightClemma = false;
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
        if (Click == true && leftClemmaRozetki.ClickLeftClemmaRozetka)
        {
            ConnectToLeftClemmaRozetki = true;
            animat.Play("RedProbeLeftRozetkaStart");
            Click = false;
            leftClemmaRozetki.ClickLeftClemmaRozetka = false;
        }
        if (Click == true && rightClemmaRozetki.ClickRightClemmaRozetka)
        {
            ConnectToRightClemmaRozetki = true;
            animat.Play("RedProbeRightRozetkaStart");
            Click = false;
            rightClemmaRozetki.ClickRightClemmaRozetka = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(69.041f, -91.624f, 70.36f))
        {
            ConnectToLeftClemma = false;
            animat.Play("RedProbeLeftBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(69.041f, -91.624f, 69.2f))
        {
            ConnectToRightClemma = false;
            animat.Play("RedProbeBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(59.214f, -68.22f, -98.375f))
        {
            ConnectToLeftClemmaRozetki = false;
            animat.Play("RedProbeLeftRozetkaBack");
            Click = false;
        }
        if (Click == true && gameObject.transform.localPosition == new Vector3(57.94f, -68.225f, -98.35f))
        {
            ConnectToRightClemmaRozetki = false;
            animat.Play("RedProbeRightRozetkaBack");
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
