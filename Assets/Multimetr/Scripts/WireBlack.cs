using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WireBlack : MonoBehaviour
{
    private Vector3 basepos;
    private Vector3 needpos;
    public Transform mA;
    private Vector3 mA_Position;
    public Transform A10;
    private Vector3 A10_Position;
    private bool Click1=false;
    [SerializeField]
    private Clicker1 clicker;
    [SerializeField]
    private Clicker2 clicker2;
    public GameObject gameObject1;
    // Start is called before the first frame update
    void Start()
    {
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
        if (clicker.Click2 && Click1)
        {
            gameObject1.transform.localPosition = mA_Position;
            Debug.Log("ДА");
            Click1 = false;
            clicker.Click2 = false;
        }
        else if (clicker2.Click3 && Click1)
        {
            gameObject1.transform.localPosition = A10_Position;
            Click1 = false;
            Debug.Log("ДА");
            clicker2.Click3 = false;
        }
        else if (Click1)
        {
            gameObject1.transform.localPosition = basepos;
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
