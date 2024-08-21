using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//clase de ejemplo para ver como se utilizarian los ataques con el jugador 
public class GameController : MonoBehaviour
{
    private Character player;

    //instanicias de diferentes ataques
    private Attack ataqueFisico;
    private Attack ataqueMagico;
    private Attack defensa;

    private void Awake()
    {
        //inicializar personaje y habilidades antes de que comience el juego
        player = new Character();
        InitializeSkills();
    }
    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            EjecutarAtaqueFisico();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EjecutarAtaqueMagico();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EjecutarDefensa();
        }
    }

    //crea instancias de los diferentes tipos de ataques
    private void InitializeSkills()
    {
        ataqueFisico = new AtaqueFisico();
        ataqueMagico = new AtaqueMagico();
        defensa = new Defensa();
    }

    //metodos especificos
    private void EjecutarAtaqueFisico()
    {
        player.UseSkill(ataqueFisico);
    }

    private void EjecutarAtaqueMagico()
    {
        player.UseSkill(ataqueMagico);
    }

    private void EjecutarDefensa()
    {
        player.UseSkill(defensa);
    }
}
