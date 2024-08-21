using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    private void Start()
    {

    }
    private void Update()
    {

    }

    public void EmpezarMision(ActivarMision mission)
    {
        if (mission != null)
        {
            mission.StartMission();
        }
    }


    public class ActivarMision : MonoBehaviour
    {
        public void Start()
        {

        }

        public void Update()
        {

        }
        public void StartMission()
        {
            Debug.Log("Comenzar");
        }

        public void CompleteMission()
        {
            Debug.Log("Logica de la Mision");
        }
    }
}
