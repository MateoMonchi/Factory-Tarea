using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Skilll : MonoBehaviour
{
    public abstract string skillName { get; }
    public abstract void Activate();
}


