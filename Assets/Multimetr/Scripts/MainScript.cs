using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public TextMesh tm;
    private rotateright rotateright;
    private rotateleft rotateleft;
    [SerializeField]
    private rotate rotate;
    [SerializeField]
    private button1 button1;
    [SerializeField]
    private button2 button2;
    [SerializeField]
    private ClickerMA clickerMA;
    [SerializeField]
    private Clicker10A clicker10A;
    [SerializeField]
    private ClickerV clickerV;
    [SerializeField]
    private ClickerCOM clickerCOM;
    [SerializeField]
    private WireBlack wireBlack;
    // Start is called before the first frame update
    void Start()
    {
        tm = (TextMesh)GameObject.Find("TextMultimetr").GetComponent<TextMesh>();
        rotate.Rotating(KrytilkaChanged);
        button1.Button1Click(OnOff);
        button2.Button2Click(AC_DC);
        clickerMA.ButtonMACLick(MA);
        clicker10A.Button10AClick(A10);
        clickerV.ButtonVClick(V);
        clickerCOM.ButtonCOMClick(COM);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void KrytilkaChanged()
    {
        Debug.Log("Сейчас режим" + rotate.counter);
    }
    private void OnOff()
    {
        if (button1.work1 == true)
            tm.text = "000.00";
        else
            tm.text = " ";
        Debug.Log("Включение =" + button1.work1);
    }
    private void AC_DC()
    {
        Debug.Log("Режим AC/DC" + button2.work2);
    }
    private void A10()
    {
        Debug.Log("Подключен коннектор к 10A");
    }
    private void COM()
    {
         Debug.Log("Подключен коннектор к COM");
    }
    private void V()
    {
        Debug.Log("Подключен коннектор к V");
    }
    private void MA()
    {
        Debug.Log("Подключен коннектор к mA");
    }
}
