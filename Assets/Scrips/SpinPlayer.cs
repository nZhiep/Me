using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlayer : MonoBehaviour
{
    public GameObject OngNgam;
    //public GameObject Player;
    Vector3 Vtri0;
    private bool quick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vtri0 = OngNgam.transform.position;
        if(quick)
        {
            clickDown();
        }
        //setDC();
    }
    public void clickDown()
    {
        
        //Vector3 Vtri0 = OngNgam.transform.position;
        Vector3 dir = Vtri0 - transform.position;
        dir.Normalize();
        float vecto = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, vecto );
        Debug.Log(vecto);
    }
    public void clickUp()
    {

        Vector3 dir = Vtri0 - transform.position;
        dir.Normalize();
        float vecto = 1.1f+(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        transform.rotation = Quaternion.Euler(0f, 0f, vecto);
        Quaternion.Inverse(transform.rotation);
        //Debug.Log(vecto);
    }
    public void SpinQuick()
    {
        quick = true;
    }
    public void UnSpinQuick()
    {
        quick = false;
    }
}
