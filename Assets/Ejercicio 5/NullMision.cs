using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Null Object evita problemas de referencia nulas al proporcionar un objeto por 
//defecto que puede ser usado en lugar de null
public class NullMision : ActivarMision
{
    public NullMision() { }

    public override void StartMission()
    {
        base.StartMission();
    }

    public override void CompleteMission()
    {
        base .CompleteMission();
    }
}
