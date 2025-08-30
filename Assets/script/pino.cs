using UnityEngine;

public class pino : MonoBehaviour
{
    public Rigidbody2D rb; 
    public float pinox;
    public float pinoy;
    public float iniciox;
    public float inicioy;
    public float y; // el valor lo toma de managemennt.cs
    public float x; // el valor lo toma de managemennt.cs





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        iniciox = transform.position.x;
        inicioy = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(iniciox+pinox+x, inicioy+pinoy+y, 0);
        if (y>10f)
        {
            pinox = Random.Range(-11, 11);
            pinoy = y;
        }
    }
}
