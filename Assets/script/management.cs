using TMPro;
using UnityEngine;

public class management : MonoBehaviour
{
    public float x;           //  pocision en Y
    public float delta;       //variacion en el eje X
    public float speed;       // velocidad
    public float time;        // variable para controlas el valor tiempo
    public float score;       // puntaje
    public float direccion;   //direccion que indica el teclado
    public TextMeshProUGUI scoreText; // referencia al componente TextMeshProUGUI para mostrar el puntaje
    public TextMeshProUGUI ganasteText; // referencia al componente TextMeshProUGUI para canvas de ganaste
    public TextMeshProUGUI pressRText; // referencia al componente TextMeshProUGUI para canvas de presiona R para reiniciar


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
        if (score > 100f) // si el puntaje es mayor o igual a 100 muestra el mensaje de ganaste
        {
            ganasteText.text = "<<< G A N A S T E >>";// muestra el texto de ganaste 
            pressRText.text = "Press R to START";// muestra el texto de reinicio 

            if (Input.GetKeyDown(KeyCode.R)) // si se presiona la tecla R reinicia el juego
            {
                
                score = 0;
                speed = 0.0001f;
                delta = 1;
                x = 0;
                direccion = 0;
                time = 0;
                ganasteText.text = "";// muestra el texto de ganaste 
                pressRText.text = "";// muestra el texto de reinicio 
            }
        }


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
            speed = speed + 0.0002f;
            if (speed > 0.05f) speed = 0.05f; // limita la velocidad maxima   
            score = score + 0.1f;
            x = x + (delta * speed);
            scoreText.text = "Score: " +  score.ToString(); // actualiza el texto del puntaje
        }
    }
    }

