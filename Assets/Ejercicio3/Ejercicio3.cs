using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public void UseSkill(string type)
    {
        switch (type)
        {
            case "PhysicalAttack":
                AtaqueFisico();
                break;
            case "MagicAttack":
                AtaqueMagico();
                break;
            case "Defense":
                Defensa();
                break;
            default:
                break;
        }
    }


    //Este metodo es para calcular el daño Fisico
    private void AtaqueFisico()
    {
        Debug.Log("Logica de Ataque fsico");
    }

    //Este metodo es para calcular el daño Magico
    private void AtaqueMagico()
    {
        Debug.Log("Logica de Ataque magico");
    }

    //Este metodo es para calcular la Defesna
    private void Defensa()
    {
        Debug.Log("Logica de defensa");
    }

}
