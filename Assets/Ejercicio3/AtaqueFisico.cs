using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueFisico : Attack
{
    //clase nueva que hereda de clase Attack que implementa logica de ataque fisico

    public override void Ejecute()
    {
        Debug.Log("Logica de Ataque fsico");
    }
}
