using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attacking : MonoBehaviour
{
    //private GameObject player;
    private Animator animator;
    public Button buttonA;
    //private int i = 0;
    private float tg;
    
    // Start is called before the first frame update
    void Start()
    {
        buttonA.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Atak();
    }
    private void Awake()
    {
        animator = GetComponent<Animator>();
        this.tg = Time.fixedDeltaTime;
    }
    public void Atak()
    {
        animator.SetBool("Shoot", true);
    }
    public void endClick()
    {
        animator.SetBool("Shoot", false);
        buttonA.gameObject.SetActive(false);
    }
}
