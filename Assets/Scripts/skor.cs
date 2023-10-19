using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class skor : MonoBehaviour
{
    public static int can = 3;
    public static int score;
    public static int score2;
    public static List<GameObject> meyveler = new List<GameObject>();
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
        switch (can)
        {
            case 3:
                can3.SetActive(true);
                can2.SetActive(true);
                can1.SetActive(true);
                break;
            case 2:
                can3.SetActive(false);
                can2.SetActive(true);
                can1.SetActive(true);
                break;
            case 1:
                can3.SetActive(false);
                can2.SetActive(false);
                can1.SetActive(true);
                break;
            case 0:
                can3.SetActive(false);
                can2.SetActive(false);
                can1.SetActive(false);
                break;
            default:
                can3.SetActive(false);
                can2.SetActive(false);
                can1.SetActive(false);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="zehir")
        {
            Destroy(collision.gameObject);
            can--;
            if (can<=0)
            {
                score=0;
                score2=0;
                Time.timeScale=0;
                SceneManager.LoadScene("bitis");
            }
        }
        else
        {
            score++;
            meyveler.Add(collision.gameObject);
            scoretext.text = score.ToString();
            if (score >= 5)
            {
                score2++;
                score2text.text = score2.ToString();
                score = 0;
                scoretext.text = score.ToString();
                foreach (var i in meyveler)
                {
                    Destroy(i);
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision2)
    {
        if (collision2.gameObject.tag != "zehir")
        {
            score--;
            scoretext.text = score.ToString();
        }
    }
}
