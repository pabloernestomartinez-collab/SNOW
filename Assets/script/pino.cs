using UnityEngine;

public class pino : MonoBehaviour
{
    // sugerencia del visual: public GameObject pino1;
    public Rigidbody2D rb; 
    public int pinox;
    public int pinoy;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pinox, pinoy, 0);

    }
}
