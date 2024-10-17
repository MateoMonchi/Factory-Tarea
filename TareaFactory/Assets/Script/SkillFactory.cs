using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    [SerializeField] private Skilll[] skills; // Array de habilidades, asignado desde el Inspector
    private Dictionary<string, Skilll> skillsByName; // Diccionario de habilidades

    private void Awake()
    {
        // Inicializamos el diccionario de habilidades
        skillsByName = new Dictionary<string, Skilll>();

        // Llenamos el diccionario con los nombres y prefabs de habilidades
        foreach (var skill in skills)
        {
            if (skill != null)
            {
                skillsByName.Add(skill.skillName, skill);
            }
        }
    }

    public Skilll CreateSkill(string skillName, Transform playerTransform)
    {
        if (skillsByName.TryGetValue(skillName, out Skilll skillPrefab))
        {
            // Crear la habilidad en la posición del jugador
            Skilll skillInstance = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
            return skillInstance;
        }
        else
        {
            // Si no encuentra la habilidad, mostrar advertencia
            Debug.LogWarning($"La habilidad '{skillName}' no existe en la base de datos de habilidades.");
            return null;
        }
    }
}

