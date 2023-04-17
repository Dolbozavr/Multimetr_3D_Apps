using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WireBlack : MonoBehaviour
{
    private Vector3 basepos;
    private Vector3 needpos;
    private Vector3 posemA;
    public Transform mA;
    private Vector3 mA_Position;
    public Transform A10;
    private Vector3 A10_Position;
    private bool Click1=false;
    [SerializeField]
    private ClickerMA clickerMA;
    [SerializeField]
    private Clicker10A clicker10A;
    [SerializeField]
    private ClickerCOM clickerCOM;
    [SerializeField]
    private ClickerV clickerV;
    public GameObject gameObject1;
    public bool WireBlackOn=false;
    [SerializeField]
    private Animation anima;
    // Start is called before the first frame update
    void Start()
    {
        //anim = gameObject.GetComponent<Animator>();
        if (mA == null)
        {
            mA = GameObject.Find("mA").GetComponent<Transform>();
        }
        basepos = gameObject.transform.localPosition;
        if (A10==null)
        {
            A10 = GameObject.Find("10A").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (clickerMA.ClickMA && Click1)
        {
            anima.Play("WireStartMa");
            //anim.SetBool("Playe", true);
            //gameObject1.transform.localPosition = mA_Position;
             
            Click1 = false;
            clickerMA.ClickMA = false;
        }
        else if (clicker10A.Click10A && Click1)
        {
            anima.Play("WireStart10A");
            //gameObject1.transform.localPosition = A10_Position;
            //anim.SetBool("Playr", true);
            Click1 = false;
             
            clicker10A.Click10A = false;
        }
        else if (clickerCOM.ClickCOM && Click1)
        {
            WireBlackOn = true;
            anima.Play("WireStartCOM");
            Click1 = false;
             
            clickerCOM.ClickCOM = false;
        }
        else if (clickerV.ClickV && Click1)
        {
            anima.Play("WireStartV");
            Click1 = false;
             
            clickerV.ClickV = false;
        }
        else if (Click1 && gameObject.transform.localPosition==new Vector3(1.53f, 0.96f, 4.8f))
        {
            anima.Play("WireBackMa");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            Click1 = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(1.548f, 1.07f, 6.26f))
        {
            anima.Play("WireBack10A");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            Click1 = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(-0.248f, 1.02f, 5.591f))
        {

            anima.Play("WireBackCOM");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            WireBlackOn = false;
            Click1 = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(-2.178f, 0.932f, 5.535f))
        {
            anima.Play("WireBackV");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            Click1 = false;
        }
    }
    private void OnMouseDown()
    {
        mA_Position = mA.localPosition;
        A10_Position = A10.localPosition;

        Click1 = true;
        Debug.Log("������ ������� �����");
    }
}
