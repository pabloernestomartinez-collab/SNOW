using UnityEngine;

public class player : MonoBehaviour
{
    public float direccion = 1; // direccion del player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        management mg = GameObject.Find("management").GetComponent<management>(); // toma los valores de management.cs
        if (mg != null)
        {
            direccion = mg.delta; // actualiza la direccion segun management.cs
        }
        transform.localScale = new Vector3(direccion, 1.0f, 1.0f); // mueve el player segun la direccion

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("se lee este renglon???... ");// controla si se imprime este renglon.
        if (collision.gameObject.GetComponent<player>() != null)
        {
            //management mg = GameObject.Find("management").GetComponent<management>(); // toma los valores de management.cs
            //mg.score -= 5; // resta 5 puntos al puntaje
            Debug.Log("collisionando... ");// + mg.score); // muestra el puntaje en la consola
        }
        else
        {
            Debug.Log("no collisionando... ");
        }
    }



    /*
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

        if (playerHealth == null)
        {

        }
        else
        {
            playerHealth.DamagePlayer(damage);
        }
    }
     */




}
