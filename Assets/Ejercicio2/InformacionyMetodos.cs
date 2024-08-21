using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InformacionyMetodos : MonoBehaviour
{

    public string personajeName;
    public int hp;
    public int attack;
    public int defense;
    public bool isDead;
   

    //creacion de metodo virtual para poder utilizarlo por multiples objetos que hereden de esta clase
    public virtual void Attack()
    {
        if (!isDead)
        {
            int damageDealt = attack - defense;
            if (damageDealt > 0)
            {
                hp -= damageDealt;
                if (hp <= 0)
                {
                    isDead = true;
                }
            }
        }
    }
}
