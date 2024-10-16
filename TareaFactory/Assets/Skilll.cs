using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Skilll : MonoBehaviour
{
    // Propiedad abstracta para obtener el nombre de la habilidad
    public abstract string skillName { get; }

    // Método abstracto que define cómo se activará la habilidad
    public abstract void Activate();
}
// Clase que representa la habilidad de curación
public class HealSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Heal";

    // Lógica de activación de la habilidad Heal
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal: el jugador se cura.");
        // Aquí puedes agregar lógica de curación, como restaurar salud al jugador
    }
}


// Clase que representa la habilidad de envenenamiento
public class PoisonSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Poison";

    // Lógica de activación de la habilidad Poison
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Poison: el enemigo es envenenado.");
        // Aquí puedes agregar la lógica para aplicar daño gradual al enemigo por envenenamiento
    }
}

// Clase que representa la habilidad de lanzar una bola de fuego
public class FireballSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Fireball";

    // Lógica de activación de la habilidad Fireball
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Fireball: lanzar una bola de fuego.");
        // Aquí puedes implementar la lógica para lanzar una bola de fuego
    }
}
// Clase que representa la habilidad de crear un escudo defensivo
public class ShieldSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Shield";

    // Lógica de activación de la habilidad Shield
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Shield: se crea un escudo protector.");
        // Implementa la lógica para aumentar la defensa o crear un escudo alrededor del jugador
    }
}
// Clase que representa la habilidad de aumento de velocidad
public class SpeedBoostSkill : Skilll
{
    // Nombre de la habilidad
    public override string skillName => "Speed Boost";

    // Lógica de activación de la habilidad Speed Boost
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Speed Boost: aumento de velocidad.");
        // Lógica para aumentar temporalmente la velocidad del jugador
    }
}



