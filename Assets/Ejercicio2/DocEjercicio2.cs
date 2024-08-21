using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocEjercicio2 : MonoBehaviour
{
    public string personajeName;
    public int hp;
    public int attack;
    public int defense;
    public bool isDead;

    public void Informacion(string name, int health, int attack, int defense)
    {
        Debug.Log(name);
        Debug.Log(health);
        Debug.Log(attack);
        Debug.Log(defense);
    }

    public void Attack()
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

    public void CastSpell()
    {
        if (!isDead)
        {
            int spellPower = 10;
            int spellDamage = spellPower - defense;
            if (spellDamage > 0)
            {
                hp -= spellDamage;
                if (hp <= 0)
                {
                    isDead = true;
                }
            }
        }
    }

    public void Heal()
    {
        if (!isDead)
        {
            hp += 15;
        }
    }
}
