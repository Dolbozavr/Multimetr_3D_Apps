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
    // Start is called before the first frame update
    void Start()
    {
        tm = (TextMesh)GameObject.Find("TextMultimetr").GetComponent<TextMesh>();
        rotate.Rotating(KrytilkaChanged);
        button1.Button1Click(OnOff);
        button2.Button2Click(AC_DC);
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
}
