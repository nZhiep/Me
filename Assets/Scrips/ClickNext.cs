using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickNext : MonoBehaviour
{
    public Animator animatorWin;
    public Animator animatorLoss;
    public Button buttonNext;
    public Button buttonRestart;
    public Scene newScene;
    public GameObject canvas;
    public GameObject canvas2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextClick()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.SetActiveScene
        if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings-1)
        {
            animatorWin.SetBool("Win", false);
            buttonNext.gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            buttonNext.gameObject.SetActive(false);
        }    
        

        //this.Unload
    }
    public void RestartClick()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.
        animatorLoss.SetBool("Loss", false);
        buttonRestart.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void PauseGame()
    {
        canvas.SetActive(false);
        canvas2.SetActive(true);

    }
    public void QuitClick()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.SetActiveScene
        animatorWin.SetBool("Win", false);
        buttonNext.gameObject.SetActive(false);
        SceneManager.LoadScene(0);

        //this.Unload
    }

}
