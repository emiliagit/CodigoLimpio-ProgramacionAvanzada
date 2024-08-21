using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1Nuevo : MonoBehaviour
{

    public float Fuerza = 100f;
    private float moveSpeed = 5f;
    private Rigidbody2D rb_2d;

    public float speed;
    void Start()
    {
        rb_2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerInputs();
    }

    //creacion de metodo para inputs de movimiento de player
    void PlayerInputs()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        //llamada a metodo de movimiento mediante vector 3 y rb
        Movement(x, y);
    }

   //metodo para movimiento 2d de player segun la velocidad y el tiempo transcurrido
    private void Movement(float inputX, float inputY)
    {
        Vector3 movement = new Vector3(inputX, inputY, 0) * moveSpeed * Time.deltaTime;

        //transform.Translate(movement);
        rb_2d.AddForce(movement); // cambio de linea de codigo utilizando la fisica del objeto
    }
}
