using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class manages the building and machinery
/// </summary>
public class HomeManager : PersistentEngineSingleton<HomeManager>
{
    List<HomeObject> m_StaticBarnObjects; // items that do not change over time: walls, fencess, etc.
    List<HomeObject> m_DynamicBarnObjects; // items that change over time
    
    // m_BarnClockEvents list of events that may be repeating, like feeding times
    public float m_MinX = -100f, m_MaxX = 100f, m_MinY = 0.5f, m_MaxY = 0.5f, m_MinZ = -100f, m_MaxZ = 100f;
    

    // Start is called before the first frame update

    // Start is called before the first frame update
    public HomeManager()
    {
        m_StaticBarnObjects = new List<HomeObject>();
        m_DynamicBarnObjects = new List<HomeObject>();             
    }    

    public void Update()
    {
        foreach (HomeObject dynamic_barn_object in m_DynamicBarnObjects)
        {
            dynamic_barn_object.Update();
        }
    }
    
    internal void GetBounds(ref Vector3 low_left, ref Vector3 high_top)
    {
        low_left.Set(m_MinX, m_MinY, m_MinZ);
        high_top.Set(m_MaxX, m_MaxY, m_MaxZ);

        return;
    }
}
