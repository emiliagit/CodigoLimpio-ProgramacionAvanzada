using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//nueva clase inicializando una instancia de myMision a NullMision y en empezar mision 
//ya no es necesario verificar si myMyision es null porque siempre habra un myMision valiso
public class NuevoEjercicio5 : MonoBehaviour
{
    [SerializeField] private ActivarMision myMision;

    private void Awake()
    {
        myMision = new NullMision();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmpezarMision()
    {
        myMision.StartMission();
        myMision.CompleteMission();
    }
}
