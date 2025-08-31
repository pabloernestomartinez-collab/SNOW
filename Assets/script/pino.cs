using UnityEngine;

public class pino : MonoBehaviour
{
    public Rigidbody2D rb; 
    public float iniciox;
    public float inicioy;
    public float y; // el valor lo toma de managemennt.cs
    public float x; // el valor lo toma de managemennt.cs

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // toma los valores del rigidbody2D al iniciar
        iniciox = transform.position.x;
        inicioy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        management mg = GameObject.Find("management").GetComponent<management>(); // toma los valores de management.cs
        if (mg != null) 
            {
            y = mg.y + inicioy; // actualiza el valor de y segun management.cs
            x = mg.x + iniciox; // actualiza el valor de x segun management.cs
        }


        transform.position = new Vector3(x, y, 0); // actualiza la posicion del pino segun los valores de X e Y
        if (y>10f)
        {
            iniciox = Random.Range(-11, 11);
            inicioy = mg.y;
        }
    }
}
