using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed;
    private Rigidbody2D Rb;
    public float JumpForce; //cambio de nombre de Speed2 para identificarlo mejor
    bool isGrounded = true; // eliminacion de bool esta_Saltando porque no cumple ninguna funcion
    private Vector2 moveDirection;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovPlayer();
        FlipPlayer();

        if((Input.GetKeyDown(KeyCode.W)) && isGrounded)
        PlayerJump();
    }

    private void MovPlayer()
    {
        Vector2 playerInput = PlayerInput();
        MovementForce(playerInput);
    }

    private Vector2 PlayerInput()
    {
        float movimiento_x = Input.GetAxis("Horizontal");
        return moveDirection = new(movimiento_x, 0f);
    }

    private void MovementForce(Vector3 direction)
    {
        Rb.AddForce(direction * movementSpeed);
    }

    private void PlayerJump()
    {
            //Le aplico la fuerza de salto
            Rb.AddForce(Vector2.up * JumpForce);
            Debug.Log("Estoy saltando Wiiii");
            isGrounded = false;
        
    }

    //cambio de logica de rotacion de player
    void FlipPlayer()
    {
        if(moveDirection.x > 0f)
        {
            transform.localScale = new Vector3(1, 1, 1); //right
        }
        if (moveDirection.x < 0f)
        {
            transform.localScale = new Vector3(-1, 1, 1); //left
        }
    }


}
