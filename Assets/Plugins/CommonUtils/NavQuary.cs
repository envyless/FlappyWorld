using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

/// <summary>
/// quary for navigation
/// </summary>
public class NavQuary
{
    static NavQuaryControl nqc;
            
    /// <summary>
    /// Subscribe this, when you want check find step
    /// </summary>
    /// <param name="reqID"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public static ReactiveProperty<bool> FindPath(int reqID, Vector3 from, Vector3 to)
    {
        return nqc.FindPath(reqID, from, to);
    }
}

/// <summary>
/// managing nav quary request
/// </summary>
class NavQuaryControl
{    
    ReactiveProperty<bool> IsUpdated = new ReactiveProperty<bool>();

    internal ReactiveProperty<bool> FindPath(int reqID, Vector3 from, Vector3 to)
    {
        return IsUpdated;
    }
}