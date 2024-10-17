using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSkill : Skilll
{
    public override string skillName => "Fireball";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Fireball: lanzar una bola de fuego.");
    }
}