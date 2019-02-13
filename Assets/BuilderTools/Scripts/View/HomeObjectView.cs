using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CowVieW manages the visual cow model
/// </summary>
public class HomeObjectView : MonoBehaviour
{
    public HomeObject m_HomeObjectModel;

    public Animator m_Animator;

    public List<GameObject> m_ProximityObjects;

    //public GameObject m_BabyHolder;
    //public GameObject m_Baby;


    // Start is called before the first frame update
    void Start()
    {
        m_ProximityObjects = new List<GameObject>();
    }

    public void Init(HomeObject model)
    {
        m_HomeObjectModel = model;        
    }

    void Update()
    {
        //if (null != m_Baby)
        //{
        //    m_Baby.transform.position = m_BabyHolder.transform.position;
        //    m_Baby.transform.rotation = m_BabyHolder.transform.rotation;
        //}
    }

    //public void CarryBaby(GameObject baby)
    //{
    //    m_Baby = baby;
    //    ((BabyModel)(m_Baby.GetComponent<HomeObjectView>().m_HomeObjectModel)).IsCarried = true;
    //}

    //public void DropBaby(GameObject target = null)
    //{
    //    if (null != target)
    //    {
    //        // :TODO: Drop baby to another holder like feeding chair
    //        target.GetComponentInChildren<FeedingChairView>().CarryBaby(m_Baby);
    //        m_Baby = null;
    //    }
    //    else
    //    {
    //        ((BabyModel)(m_Baby.GetComponent<HomeObjectView>().m_HomeObjectModel)).IsCarried = false;
    //        m_Baby = null;
    //    }

    //}


    private void OnTriggerEnter(Collider other)
    {

        //HomeObjectView test = other.gameObject.GetComponent<HomeObjectView>();

        //if (test && (test.m_HomeObjectModel.m_ObjectName.Equals("BabyModel") ||
        //            test.m_HomeObjectModel.m_ObjectName.Equals("NannyModel")))
        //{
        //    //Debug.Log("TRIGGER ENTER");
        //    m_ProximityObjects.Add(other.gameObject);
        //}

        // Keep list of babies and nannies within close range
    }

    private void OnTriggerExit(Collider other)
    {
        //HomeObjectView test = other.gameObject.GetComponent<HomeObjectView>();

        //if (test && (test.m_HomeObjectModel.m_ObjectName.Equals("BabyModel") ||
        //            test.m_HomeObjectModel.m_ObjectName.Equals("NannyModel")))
        //{
        //    //Debug.Log("TRIGGER EXIT");
        //    m_ProximityObjects.Remove(other.gameObject);
        //}

        // Keep list of babies and nannies within close range
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("COLLISION CONTACT");
    }
}
