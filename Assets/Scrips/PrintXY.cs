using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintXY : MonoBehaviour
{
    public Transform vtriXY;
    Vector2 Vitri0 = new Vector2(0f, 0f);
    public Text xText ;
    public Text yText ;
    private bool quick;
    private void Awake()
    {
        //vtriXY = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Vitri0 = vtriXY.position;
        xText.text = Vitri0.x.ToString();
        yText.text = Vitri0.y.ToString();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (quick)
        {
            gettext();
        }
        //gettext();
    }
    public void gettext()
    {
        xText = GameObject.Find("X").GetComponent<Text>();
        yText = GameObject.Find("Y").GetComponent<Text>();
        xText.text = vtriXY.position.x.ToString();
        yText.text = vtriXY.position.y.ToString();
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
