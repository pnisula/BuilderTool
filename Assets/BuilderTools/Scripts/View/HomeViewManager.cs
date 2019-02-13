using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BarnViewManager manages the visual models in the simulator scene
/// </summary>
[Serializable]
public class HomeViewManager : PersistentSceneSingleton<HomeViewManager>
{
    public GameObject m_Building;
    public List<GameObject> m_Walls;
    public List<GameObject> m_Fences;
    public List<GameObject> m_FeedingPosts;
    public List<GameObject> m_WateringPosts;

    public GameObject m_NannyPrefab;
    public GameObject m_NannyFolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
}
