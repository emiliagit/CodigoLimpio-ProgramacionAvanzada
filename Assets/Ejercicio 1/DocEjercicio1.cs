using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocEjercicio1 : MonoBehaviour
{
    public float Fuerza = 100f;
    private float moveSpeed = 5f;
    private Rigidbody2D rb_2d;

    public float speed;

    private void Start()
    {
        rb_2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Movimiento del jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        // Mover el jugador
        Vector3 movement = new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

    }
}
