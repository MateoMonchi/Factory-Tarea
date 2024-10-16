using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Skilll : MonoBehaviour
{
    // Propiedad abstracta para obtener el nombre de la habilidad
    public abstract string skillName { get; }

    // M�todo abstracto que define c�mo se activar� la habilidad
    public abstract void Activate();
}
// Clase que representa la habilidad de curaci�n
public class HealSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Heal";

    // L�gica de activaci�n de la habilidad Heal
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal: el jugador se cura.");
        // Aqu� puedes agregar l�gica de curaci�n, como restaurar salud al jugador
    }
}


// Clase que representa la habilidad de envenenamiento
public class PoisonSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Poison";

    // L�gica de activaci�n de la habilidad Poison
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Poison: el enemigo es envenenado.");
        // Aqu� puedes agregar la l�gica para aplicar da�o gradual al enemigo por envenenamiento
    }
}

// Clase que representa la habilidad de lanzar una bola de fuego
public class FireballSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Fireball";

    // L�gica de activaci�n de la habilidad Fireball
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Fireball: lanzar una bola de fuego.");
        // Aqu� puedes implementar la l�gica para lanzar una bola de fuego
    }
}
// Clase que representa la habilidad de crear un escudo defensivo
public class ShieldSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Shield";

    // L�gica de activaci�n de la habilidad Shield
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Shield: se crea un escudo protector.");
        // Implementa la l�gica para aumentar la defensa o crear un escudo alrededor del jugador
    }
}
// Clase que representa la habilidad de aumento de velocidad
public class SpeedBoostSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Speed Boost";

    // L�gica de activaci�n de la habilidad Speed Boost
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Speed Boost: aumento de velocidad.");
        // L�gica para aumentar temporalmente la velocidad del jugador
    }
}



