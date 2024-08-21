using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // clase que toma un objeto tipo Attack como parametro
    public void UseSkill(Attack type)
    {
        type.Ejecute();
    }
}
