using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour
{
    //clase padre que define el metodo Ejecute para ser implementado por las clases derivadas
    public abstract void Ejecute();
}
