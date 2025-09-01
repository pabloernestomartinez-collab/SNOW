using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pino : MonoBehaviour
{
    public float time;      // variable para controlas el valor tiempo, el valor lo toma de mg
    public float delta;
    public float speed;     // variable para controlas la velocidad, el valor lo toma de mg
    public float y;         // el valor lo toma de managemennt.cs
    public float x;         // el valor lo toma de managemennt.cs

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        management mg = GameObject.Find("management").GetComponent<management>(); // toma los valores de management.cs
        if (mg != null) 
        {
            delta = mg.delta; // actualiza el valor de x segun management.cs
            speed = mg.speed;
        }

        y = y + speed;

        if (y > 6) // reinicia la posicion si baja mucho en el eje Y
        {
            x = Random.Range(-6, 6); // toma un valor aleatorio para X
            y = -7;
        }
        x = x + (delta * speed);

        transform.position = new Vector3(x, y, 0); // actualiza la posicion del pino segun los valores de X e Y
    }
}
