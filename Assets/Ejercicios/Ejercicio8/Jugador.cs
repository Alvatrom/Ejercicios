using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float fuerzaSalto = 5.8f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Salto();
    }
    void Salto()
    {
        if (Input.GetKeyDown(KeyCode.W))
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
    }
}
