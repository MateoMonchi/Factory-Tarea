using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Skilll : MonoBehaviour
{
    public abstract string skillName { get; }
    public abstract void Activate();
}
public class HealSkill : Skilll
{
    public override string skillName => "Heal";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal: el jugador se cura.");
    }
}
public class FireballSkill : Skilll
{
    public override string skillName => "Fireball";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Fireball: lanzar una bola de fuego.");
    }
}
