using UnityEngine;


public class management : MonoBehaviour
{
    public int x;
    public int y;
    public int delta;
    public float speed;
    public float time;
    public int score;
    public float direccion;
    public Rigidbody2D rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // define the initial values
        speed = 0f;
        delta = 1;
        x= 10;  

    }

    // Update is called once per frame
    void Update()
    {
        
        // determina cuales son las nuevas coordenadas 
        time = time + Time.deltaTime;
        if (y < -5) 
        { 
            y = 10;
        }
        
        if ((x < -10)||(direccion == -1))   
        {
            delta = 1;
        }
        if ((x > 10)||(direccion == 1))
        {
            delta = -1;
        }
        
        direccion = Input.GetAxisRaw("Horizontal");


        // determina la nueva pocision de la matrix
        if (time > speed) 
        {
            y = y - 1;
            time = 0;
            speed = 1-Time.time*0.01f;
            x = x + delta;
            score = score + 1;  

        }        
    }
}
