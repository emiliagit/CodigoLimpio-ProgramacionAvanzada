using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseHeredada : InformacionyMetodos
{
    // clase hija que hereda y ejecuta metodo de ataque
    private void Update()
    {
        Attack();
    }

    public override void Attack()
    {
        base.Attack();
        //logica adicional 
    }
}
