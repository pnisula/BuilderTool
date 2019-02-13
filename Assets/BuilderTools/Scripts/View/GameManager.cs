using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

/// <summary>
/// 
/// GameManager instantiates the BarnManager and CowManager, as well as respective views.
/// 
/// It acts as interface between view/builder tool and the simulator engine
/// 
/// </summary>
public class GameManager : PersistentSceneSingleton<GameManager>
{    
    HomeManager m_HomeManager;

    public float m_GameDeltaTime;

    public float m_GameSpeed;

    private int _earlierDate;
       
    // Start is called before the first frame update
    void Start()
    { 
        m_HomeManager = new HomeManager ();

        m_GameSpeed = 1f;        
    }
    
    // Update is called once per frame
    void Update()
    {
        m_GameDeltaTime = Time.deltaTime * m_GameSpeed;

        m_HomeManager.Update();                        
    }    
}
