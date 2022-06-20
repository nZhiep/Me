using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinPlayer : MonoBehaviour
{
    public GameObject OngNgam;
    //public GameObject Player;
    Vector3 Vtri0;
    private bool quick;
    private bool clickQup;
    private bool clickQdown;

    int i = 1;
    public Button Quickbtn;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vtri0 = OngNgam.transform.position;
        if (clickQdown)
        {
            toDown();
        }
        if (clickQup)
        {
            toUp();
        }

        //setDC();
    }
    public void clickDown()
    {
        if (quick == true)
        {
            clickQdown = true;
        }
        {
            toDown();
        }


    }
    public void clickUp()
    {
        if (quick == true)
        {
            clickQup = true;
        }
        else
        {
            toUp();
        }
        
    }
    public void UnClickUp()
    {
        clickQup = false;
    }
    public void UnClickDown()
    {
        clickQdown = false;
    }
    public void ClickQuick()
    {
        i++;
        if(i %2 == 0)
        {
            Quickbtn.image.color = new Color32(250,250,250,250);
            quick = true;
        }
        else
        {
            Quickbtn.image.color = new Color32(250, 250, 250, 36);
            quick = false;
        }
    }
    public void toDown()
    {
        Vector3 dir = Vtri0 - transform.position;
        dir.Normalize();
        float vecto = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, vecto);
        //Debug.Log(vecto);
    }
    public void toUp()
    {
        Vector3 dir = Vtri0 - transform.position;
        dir.Normalize();
        float vecto = 1.1f + (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        transform.rotation = Quaternion.Euler(0f, 0f, vecto);
        Quaternion.Inverse(transform.rotation);
    }
}
