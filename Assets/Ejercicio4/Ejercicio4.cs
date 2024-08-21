using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public float _Speed;
    bool esta_Saltando;
    public float Z;
    private Rigidbody2D fisicas;
    public float _Speed2;
    bool isJumping;

    private void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        //Movimiento del jugador - Der
        if (Input.GetKeyDown(KeyCode.D))
        {
            float movimiento_x = Input.GetAxis("Horizontal");
            fisicas.velocity = new Vector2(movimiento_x, 0);
        }
        //Movimiento del jugador - Izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            float movimiento_x = Input.GetAxis("Horizontal");
            fisicas.velocity = new Vector2(movimiento_x, 0);
        }
        //Rotacion del jugador
        if (Input.GetKeyDown(KeyCode.R))
        {
            Z += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(0, 0, Z);

        }
        //Salto del jugador 
        if (Input.GetButton("Jump") && !esta_Saltando)
        {
            //Le aplico la fuerza de salto
            fisicas.AddForce(Vector2.up * _Speed2);
            Debug.Log("Estoy saltando Wiiii");
            //Digo que está saltando (para que no pueda volver a saltar)
            isJumping = true;
        }
    }
}
