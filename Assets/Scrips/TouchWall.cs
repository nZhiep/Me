using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TouchWall : MonoBehaviour
{
    Scene scene;
    public int WallLook = 3;
    private int Pointtowin = 1;
    private int Wall = 0;
    private int Count = 0;
    public Text wallcount;
    public Text WinPoint;
    public Animator animator;
    public Animator animatorWin;
    public Animator animatorLoss;
    public GameObject Ball;
    private int heart = 3;
    Vector3 save;
    public Text textHeart;
    public Button buttonA;
    public Button buttonNext;
    public Button buttonRestart;
    public Button buttonQuit;

    //public Transform ball;

    private void Awake()
    {
        //Ball = GetComponent<GameObject>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Wall = 0;
        Count = 0;
        Pointtowin = 1;
        heart = 3;
        wallcount.text = WallLook.ToString();
        WinPoint.text = Pointtowin.ToString();
        save = Ball.transform.position;
        textHeart.text = heart.ToString();

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // va chạm với tường
        if (collision.gameObject.tag == "Wall")
        {
            if (Count < WallLook)
            {
                Count++;
                Wall = WallLook - Count;
                setWall();
                if (Count == WallLook)
                {
                    Debug.Log("Wall finish");
                }
            }
            else
            {
                Count = WallLook;
                Wall = 0;
                setWall();
            }
            Debug.Log(Count);
            //Debug.Log(textHeart.text);
        }
        //va chạm với tường ngoài
        if (collision.gameObject.tag == "Elemie_wall" )
        {
            if(heart > 1)
            {
                Ball.SetActive(false);
                heart = heart - 1;
                Ball.transform.position = save;
                Ball.SetActive(enabled);
                setHeart();
                Debug.Log(heart);
                Count = 0;
                Wall = WallLook - Count;
                setWall();
                buttonA.gameObject.SetActive(true);

            }
            else
            {
                Destroy(Ball);
                heart = 0;
                Debug.Log("Game Over");
                setHeart();
                animatorLoss.SetBool("Loss", true);
                buttonRestart.gameObject.SetActive(true);
                buttonQuit.gameObject.SetActive(true);
                //buttonA.gameObject.SetActive(true);


            }
        }
        
        // va chạm với point win
        if (collision.gameObject.tag == "Win_point")
        {
            if(Count >= WallLook)
            {
                animator.SetInteger("Touch", 1);
                Pointtowin = 0;
                setPointW();
                Goal();
                //buttonA.gameObject.SetActive(true);
                //Ball.gameObject.SetActive(false);
                //Destroy(Ball.gameObject);
                Debug.Log("finish");
            }
            else
            {
                animator.SetInteger("Touch", 1);
                Pointtowin = 0;
                setPointW();
                //Goal();
                Ball.SetActive(false);
                heart = heart - 1;
                Ball.transform.position = save;
                Ball.SetActive(enabled);
                setHeart();
                Debug.Log(heart);
                Count = 0;
                Wall = WallLook - Count;
                setWall();
                animator.SetInteger("Touch", 0);
                Pointtowin = 1;
                setPointW();
                Debug.Log("heart -1");
                buttonA.gameObject.SetActive(true);
                if (heart < 1)
                {
                    Destroy(Ball);
                    heart = 0;
                    setHeart();
                    animatorLoss.SetBool("Loss", true);
                    buttonRestart.gameObject.SetActive(true);
                    buttonQuit.gameObject.SetActive(true);

                }
            }
        }
        if(Wall == 0 && Pointtowin == 0)
        {
            
            animatorWin.SetBool("Win", true);
            buttonNext.gameObject.SetActive(true);
            buttonQuit.gameObject.SetActive(true);
            saveLevel();
            Debug.Log("Wellcome To Win!!");
            
        }
    }
    public void setWall()
    {
        wallcount = GameObject.Find("NumWallCount").GetComponent<Text>();
        wallcount.text = Wall.ToString();
        //Debug.Log(textHeart.text);
    }
    public void setPointW()
    {
        WinPoint = GameObject.Find("NumWinpoint").GetComponent<Text>();
        WinPoint.text = Pointtowin.ToString();
        //Debug.Log(textHeart.text);
    }
    public void Goal()
    {
            Destroy(Ball);
            Debug.Log("Goal");
        
    }
    public void setHeart()
    {
        textHeart = GameObject.Find("NumHearts").GetComponent<Text>();
        textHeart.text = heart.ToString();
    }
    public void ResetBall()
    {
    }
    public void saveLevel()
    {
        if(PlayerPrefs.GetInt("Level") < SceneManager.GetActiveScene().buildIndex)
        {
            PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);
            Debug.Log("A = " + PlayerPrefs.GetInt("Level"));
        }
       
    }
}
