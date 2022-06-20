using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    int lv = 0;
    public GameObject loti;
    private Text lvStart;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("Level",0) ;
        lvStart = GameObject.Find("lvStart").GetComponent<Text>();
        lvStart.text = "Level : "+ (PlayerPrefs.GetInt("Level") + 1).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        
        lv = PlayerPrefs.GetInt("Level") + 1;
        if (lv < 1)
        {
            SceneManager.LoadScene(1);

        }
        else
        if (lv < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(lv);
        }
        else
        {
            loti.SetActive(true);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
