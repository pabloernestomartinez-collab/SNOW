using UnityEditor.Tilemaps;
using UnityEngine;

public class player : MonoBehaviour
{
    public float direccion = 1; // direccion del player

    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

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
}
