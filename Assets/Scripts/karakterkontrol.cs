using UnityEngine;

public class karakterkontrol : MonoBehaviour
{
    public Rigidbody2D rb;
    public float hiz;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity=new Vector2(hiz,0.0f);
        if (Input.anyKey)
        {
            if (Input.mousePosition.x<Screen.width/2 && rb.position.x>-8)
            {
                hiz=-8.5f;
            }
            else if (Input.mousePosition.x>Screen.width/2 && rb.position.x<8)
            {
                hiz=8.5f;
            }
            else
            {
                hiz=0.0f;
            }
        }
        else
        {
            hiz=0.0f;
        }
    }
}
