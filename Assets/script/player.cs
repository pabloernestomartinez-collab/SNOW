using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0.0f, 1.0f, 0);
        transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

    }
}
