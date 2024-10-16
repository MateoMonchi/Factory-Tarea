using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBoton : MonoBehaviour
{
    [SerializeField] private SkillFactory skillFactory;
    [SerializeField] private string skillName;
    [SerializeField] private Transform playerTransform;

    public void OnClick()
    {
        Skilll skill = skillFactory.CreateSkill(skillName, playerTransform);
        if (skill != null)
        {
            skill.Activate();
        }
    }
}
