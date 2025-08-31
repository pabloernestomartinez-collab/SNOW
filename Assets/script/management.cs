using UnityEngine;
//using UnityEngine.Windows;


public class management : MonoBehaviour
{
    public int x;
    public int y;
    public int delta;
    public float speed;
    public float time;
    public int score;
    public float direccion;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // define the initial values
        speed = 0f;
        delta = 1;
        x= 10;  
        y = 10;

    }

    // Update is called once per frame
    void Update()
    {
        // reinicia el juego si se presiona la tecla R
        if (Input.GetKey("r"))
        {
            y = 10;
            score = 0;
            speed = 0f;
            delta = 1;
            x = 10;
        }

        if (score > 1000) // limita el marcador a 100
        {
            score = 100;
            y = 10;
            score = 0;
            speed = 1f;
            delta = 1;
            x = 10;
            y = 10;
        }
    

        // controla si hay cambios en la direccion del player 
        direccion = Input.GetAxisRaw("Horizontal");   // segun teclado
        if (y >10)                                    // reinicia la posicion si baja mucho en el eje Y
        {
            y = -10;
        }

        if ((x < -10) || (direccion == -1)) // cambia la direccion si llega al limite de la mantalla o toque la tecla
        {
            delta = 1;
        }

        if ((x > 10) || (direccion == 1))   // cambia la direccion si llega al limite de la pantalla o toque la tecla
        {
            delta = -1;
        }

        // determina la nueva pocision de la matrix y suma un punto al marcador
        time = time + Time.deltaTime;
        if (time > speed)
        {
            y = y + 2;
            time = 0;
            speed = (100 - score) * 0.01f;
            x = x + delta;
            score = score + 1;
        }
    }
    }

