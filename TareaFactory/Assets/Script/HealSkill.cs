using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HealSkill : Skilll
{
    public override string skillName => "Heal";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal: el jugador se cura.");
    }
}