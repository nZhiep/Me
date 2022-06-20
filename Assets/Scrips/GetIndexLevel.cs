using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class GetIndexLevel : MonoBehaviour
{
    //public Text LvPlayed;
    public int a = 0;
    public Button btn;
    public GameObject loti;
    public GameObject LevelLists;
    private GameObject Levelx;
    private GameObject Lock;
    private GameObject UnL;


    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

            loadLock();
        loadUnLock();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void loadLock()
    {
        for ( int i = PlayerPrefs.GetInt("Level") +1; i > 0; i--)
        {
            Levelx = LevelLists.transform.Find("Lv" + i.ToString()).gameObject;
            //UnL = Levelx.transform.Find("unL" + i.ToString()).gameObject;
            Lock = Levelx.transform.Find("Lock" + i.ToString()).gameObject;
            //UnL.SetActive(true);
            Lock.SetActive(false);
            
        }
        //Levelx.transform.Find("Lock" + PlayerPrefs.GetInt("Level") + 1.ToString()).gameObject.SetActive(false);
    }
    void loadUnLock()
    {
        for (int i = PlayerPrefs.GetInt("Level"); i > 0; i--)
        {
            Levelx = LevelLists.transform.Find("Lv" + i.ToString()).gameObject;
            UnL = Levelx.transform.Find("unL" + i.ToString()).gameObject;
            //Lock = Levelx.transform.Find("Lock" + i.ToString()).gameObject;
            UnL.SetActive(true);
            //Lock.SetActive(false);

        }
        //Levelx.transform.Find("Lock" + PlayerPrefs.GetInt("Level") + 1.ToString()).gameObject.SetActive(false);
    }
    public void clickLevel(int lv)
    {
        if(lv <= PlayerPrefs.GetInt("Level")+1)
        {
            a = lv;
            if (a > 0 )
            {

                Debug.Log(a);
                btn.gameObject.SetActive(true);
            }
            else
            {
                
                btn.gameObject.SetActive(false);
                loti.SetActive(true);
            }
        }
        else
        {
            
            btn.gameObject.SetActive(false);
            loti.SetActive(true);
        }
    }
    public void clickStart()
    {
        if(a < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(a);
        }
    }
}
