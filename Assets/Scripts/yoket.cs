using UnityEngine;

public class yoket : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="zehir")
        {
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(collision.gameObject,5);
        }
    }
}
