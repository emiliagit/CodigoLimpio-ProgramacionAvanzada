using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueMagico : Attack
{
    //clase nueva que hereda de clase Attack que implementa logica de ataque magico
    public override void Ejecute()
    {
        Debug.Log("Logica de Ataque magico");
    }
}
