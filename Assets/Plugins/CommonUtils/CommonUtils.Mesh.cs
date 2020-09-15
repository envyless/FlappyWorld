using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Mesh 관련 Partial
/// </summary>
public static partial class CommonUtils
{
    public static ParentsGameObjects triangleParent;

    [RuntimeInitializeOnLoadMethod()]
    public static void SetUp()
    {
        triangleParent = new ParentsGameObjects("triangleParent");
    }

    public class ParentsGameObjects
    {
        GameObject parent;
        string name;
        public GameObject GetParent { get {
                if (parent == null)
                    parent = new GameObject(name);
                return null;
            } 
        }
        public ParentsGameObjects(string _name)
        {
            name = _name;
        }
    }

    public static void DrawTriangle(Vector3 v1, Vector3 v2, Vector3 v3, Color? color = null, float consistTime = 0, float lineSize = 0.2f)
    {
        LineDrawerMgr.DrawLine(v1, v2, color, consistTime, lineSize);
        LineDrawerMgr.DrawLine(v2, v3, color, consistTime, lineSize);
        LineDrawerMgr.DrawLine(v3, v1, color, consistTime, lineSize);
    }

    public static void DrawLine(Vector3 v1, Vector3 v2, Color? color=null, float consistTime = 0)
    {
        LineDrawerMgr.DrawLine(v1, v2, color, consistTime);
    }    
}
