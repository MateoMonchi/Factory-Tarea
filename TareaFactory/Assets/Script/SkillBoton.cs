using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SkillBoton : MonoBehaviour
{
    [SerializeField] private SkillFactory skillFactory;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private string skillName;

    public void OnClick()
    {
        Skilll skill = skillFactory.CreateSkill(skillName, playerTransform);
        if (skill != null)
        {
            skill.Activate();
        }
    }
}
