using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour {

    public Transform m_TerrainA;
    public Transform m_TerrainB;
    public Transform player;

    public Camera m_MainCamera;

    public GameObject m_PortalA; //A is portal destination
    public GameObject m_PortalB; //B is our portal

    public PortalCamera m_CameraA;
    public PortalCamera m_CameraB;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		//if (OVRInput.GetDown(OVRInput.Button.One))
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            TryRaycast();
        }
	}

    void TryRaycast()
    {
        Ray ray = new Ray(m_MainCamera.transform.position, m_MainCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            SpawnPortals(hit);
        }
    }

    void SpawnPortals(RaycastHit hit)
    {
        GameObject portalB = Instantiate(m_PortalB);
        portalB.transform.position = hit.point;
 
        portalB.SetActive(true);

        GameObject portalA = Instantiate(m_PortalA);
        //add check for terrain side
        if(player.transform.position.z > -500)
        {
            portalA.transform.position = hit.point - new Vector3(0, 0, 1000f);
            Debug.Log(">-500");
        }else
        {
            portalA.transform.position = hit.point + new Vector3(0, 0, 1000f);
            Debug.Log("<-500");
        }
        
        
        portalA.transform.Rotate(new Vector3(0, 180f, 0));
        portalA.SetActive(true);

        m_CameraA.SetPortalReferences(portalA.transform, portalB.transform);
        m_CameraB.SetPortalReferences(portalB.transform, portalA.transform);

        PortalTeleporter ptA = portalA.transform.GetChild(1).gameObject.GetComponent<PortalTeleporter>();
        PortalTeleporter ptB = portalB.transform.GetChild(1).gameObject.GetComponent<PortalTeleporter>();

        ptA.SetupPortalValues(transform, ptB.gameObject.transform);
        ptB.SetupPortalValues(transform, ptA.gameObject.transform);
    }
}
