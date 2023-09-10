using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class skor : MonoBehaviour
{
    public int can;
    public static int score;
    public static int score2;
    TextMeshProUGUI scoretext;
    TextMeshProUGUI score2text;
    [SerializeField] GameObject can3;
    [SerializeField] GameObject can2;
    [SerializeField] GameObject can1;
    public Rigidbody2D rb;

    private void Start()
    {
        scoretext=GameObject.Find("Canvas/scoretxt").GetComponent<TextMeshProUGUI>();
        score2text=GameObject.Find("Canvas/score2txt").GetComponent<TextMeshProUGUI>();
        can3.SetActive(true);
        can2.SetActive(true);
        can1.SetActive(true);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        if(score<0 || score2<0)
        {
            score=0;
            score2=0;
            scoretext.text=score.ToString();
            score2text.text=score2.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag!="zehir")
        {
            score++;
            scoretext.text=score.ToString();
            Destroy(collision.gameObject,10);
            if (score==5)
            {
                score2++;
                score2text.text=score2.ToString();
                score=0;
                scoretext.text=score.ToString();
            }
        }

        else if (collision.gameObject.tag=="zehir")
        {
            Destroy(collision.gameObject);
            can--;
            can3.SetActive(false);
            if (can==1)
            {
                can2.SetActive(false);
            }
            else if (can==0)
            {
                score=0;
                score2=0;
                Time.timeScale=0;
                can1.SetActive(false);
                SceneManager.LoadScene("bitis");
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision2)
    {
        if (collision2.gameObject.tag!="zehir")
        {
            score--;
            scoretext.text=score.ToString();
        }
    }
}
