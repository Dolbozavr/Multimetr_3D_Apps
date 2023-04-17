using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireRed : MonoBehaviour
{
    private Vector3 basepos;
    private Vector3 needpos;
    private Vector3 posemA;
    public Transform mA;
    private Vector3 mA_Position;
    public Transform A10;
    private Vector3 A10_Position;
    private bool Click1 = false;
    [SerializeField]
    private ClickerMA clickerMA;
    [SerializeField]
    private Clicker10A clicker10A;
    public GameObject gameObject1;
    [SerializeField]
    private ClickerCOM clickerCOM;
    [SerializeField]
    private ClickerV clickerV;
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
        if (A10 == null)
        {
            A10 = GameObject.Find("10A").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (clickerMA.ClickMA && Click1)
        {
            anima.Play("RedStartMa");
            //anim.SetBool("Playe", true);
            //gameObject1.transform.localPosition = mA_Position;
             
            Click1 = false;
            clickerMA.ClickMA = false;
        }
        else if (clicker10A.Click10A && Click1)
        {
            anima.Play("RedStart10A");
            //gameObject1.transform.localPosition = A10_Position;
            //anim.SetBool("Playr", true);
            Click1 = false;
             
            clicker10A.Click10A = false;
        }
        else if (clickerCOM.ClickCOM && Click1)
        {
            anima.Play("RedStartCOM");
            Click1 = false;
             
            clickerCOM.ClickCOM = false;
        }
        else if (clickerV.ClickV && Click1)
        {
            anima.Play("RedStartV");
            Click1 = false;
             
            clickerV.ClickV = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(1.532f, 0.855f, 4.919f))
        {
            anima.Play("RedBackMa");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            Click1 = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(1.538f, 0.85f, 6.284f))
        {
            anima.Play("RedBack10A");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            Click1 = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(-0.247f, 0.898f, 5.579f))
        {
            anima.Play("RedBackCOM");
            //anim.SetBool("Playr", false);
            //anim.SetBool("Playe", false);
            //gameObject1.transform.localPosition = basepos;
            Click1 = false;
        }
        else if (Click1 && gameObject.transform.localPosition == new Vector3(-2.146f, 0.853f, 5.571f))
        {
            anima.Play("RedBackV");
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
        Debug.Log("Первый элемент нажат");
    }
}
