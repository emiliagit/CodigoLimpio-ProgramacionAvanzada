using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class Ejercicio2Nuevo : MonoBehaviour
{
    
    //clase nueva que devuelve la informacion de las variables
    public void Informacion(InformacionyMetodos info)
    {
        Debug.Log(info.personajeName);
        Debug.Log(info.hp);
        Debug.Log(info.attack);
        Debug.Log(info.defense);
    }
}
