using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensa : Attack
{
    //clase nueva que hereda de clase Attack que implementa logica de defensa

    public override void Ejecute()
    {
        Debug.Log("Logica de defensa");
    }
}
