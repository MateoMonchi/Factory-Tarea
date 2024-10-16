using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    [SerializeField] private Skilll[] skills;
    private Dictionary<string, Skilll> skillsByName;

    private void Awake()
    {
        skillsByName = new Dictionary<string, Skilll>();
        foreach (var skill in skills)
        {
            skillsByName.Add(skill.skillName, skill);
        }
    }

    public Skilll CreateSkill(string skillName, Transform playerTransform)
    {
        if (skillsByName.TryGetValue(skillName, out Skilll skillPrefab))
        {
            Skilll skillInstance = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
            return skillInstance;
        }
        else
        {
            Debug.LogWarning($"La habilidad '{skillName}' no existe en la base de datos de habilidades.");
            return null;
        }
    }
}

