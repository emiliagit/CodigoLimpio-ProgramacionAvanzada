using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActivarMision : MonoBehaviour
{
    public virtual void StartMission()
    {
        Debug.Log("Comenzar");
    }

    public virtual void CompleteMission()
    {
        Debug.Log("Logica de la Mision");
    }
}
