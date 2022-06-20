using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_fly : MonoBehaviour
{
    public float speed ;
    //public GameObject ballPref;
    //public GameObject gunPoint;
    public Transform flyPoint;
    public Rigidbody2D rb;
    
    //Vector3 save;

    // Start is called before the first frame update
    private void Start()
    {
        //save = transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
            //Shooting();
    }
    public void Shooting()
    {
        Vector2 forxe = new Vector2(0f, 0f);

        forxe = flyPoint.position - transform.position;
        //GameObject ball = Instantiate(ballPref, flyPoint.position, flyPoint.rotation);
        //Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.AddForce(forxe * speed, ForceMode2D.Impulse);
        
    }
    private void Awake()
    {
        //gunPoint = GetComponent<GameObject>();
        
    }
}
