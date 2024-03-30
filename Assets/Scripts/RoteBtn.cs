using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteBtn : MonoBehaviour
{
    public bool BtnL = false;
    public bool BtnZP = false;
    public bool BtnF = false;
    public bool BtnUP = false;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BthL"))
        {
            BtnL = true;
            BtnZP = false;
            BtnF = false;
            BtnUP = false;
        }
        if (collision.gameObject.CompareTag("BthZP"))
        {
            BtnL = false;
            BtnZP = true;
            BtnF = false;
            BtnUP = false;
        }
        if (collision.gameObject.CompareTag("BthF"))
        {
            BtnL = false;
            BtnZP = false;
            BtnF = true;
            BtnUP = false;
        }
        if (collision.gameObject.CompareTag("BthUP"))
        {
            BtnL = false;
            BtnZP = false;
            BtnF = false;
            BtnUP = true;
        }
    }
}
