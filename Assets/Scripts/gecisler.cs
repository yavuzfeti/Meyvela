using UnityEngine;
using UnityEngine.SceneManagement;

public class gecisler : MonoBehaviour
{
    public void yeniden()
    {
        skor.score=0;
        SceneManager.LoadScene("oyun");
        Time.timeScale=1;
    }

    public void oyna()
    {
        skor.score=0;
        SceneManager.LoadScene("oyun");
        Time.timeScale=1;
    }

    public void anamenu()
    {
        skor.score=0;
        SceneManager.LoadScene("basla");
    }

    public void duraklat()
    {
        SceneManager.LoadScene("basla");
    }
}
