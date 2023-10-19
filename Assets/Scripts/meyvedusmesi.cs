using UnityEngine;

public class meyvedusmesi : MonoBehaviour
{
    [SerializeField] GameObject[] Meyve = new GameObject[12];
    public float dusmeHizi = 1.0f;

    private void Start()
    {
        InvokeRepeating("meyvegonder",0.1f,1f);
    }

    void meyvegonder()
    {
        Instantiate(Meyve[Random.Range(0,13)],transform.position=new Vector2(Random.Range(-7.5f,7.5f),transform.position.y),Quaternion.identity);
    }
}
