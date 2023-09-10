using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoket : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag!="sepet" && collision.gameObject.tag!="zehir")
        {
            Destroy(collision.gameObject,1);
        }
        if (collision.gameObject.tag=="zehir")
        {
            Destroy(collision.gameObject);
        }
    }
}
