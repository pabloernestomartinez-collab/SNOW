using UnityEngine;

public class management : MonoBehaviour
{
    public float x;           //  pocision en Y
    public float delta;       //variacion en el eje X
    public float speed;     // velocidad
    public float time;      // variable para controlas el valor tiempo
    public int score;       // puntaje
    public float direccion; //direccion que indica el teclado



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // define the initial values
        speed = 0.0001f;
        delta = 1;
        x= 0;  
        score = 0;
        direccion = 0;  
        time = 0;

    }

    // Update is called once per frame
    void Update()
    {

    

        // controla si hay cambios en la direccion del player 
        direccion = Input.GetAxisRaw("Horizontal");   // segun teclado

        if ((x < -6) || (direccion == -1)) // cambia la direccion si llega al limite de la mantalla o se toca la tecla
        {
            delta = 1;
        }

        if ((x > 6) || (direccion == 1))   // cambia la direccion si llega al limite de la pantalla o se toca la tecla
        {
            delta = -1;
        }

        // determina la nueva pocision de la matrix y suma un punto al marcador
        time = time + Time.deltaTime;

        if (time > 0.01f)
        {
            time = 0;
            speed = speed + 0.0001f;
            score = score + 1;
            x = x + (delta * speed);

        }
    }
    }

