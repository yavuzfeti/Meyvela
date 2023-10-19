using UnityEngine;
using UnityEngine.UI;

public class bitisyazdir : MonoBehaviour
{
    [SerializeField] Text myText;
    private void Start()
    {
        myText.text="Skor: "+skor.score2.ToString();
    }
}
