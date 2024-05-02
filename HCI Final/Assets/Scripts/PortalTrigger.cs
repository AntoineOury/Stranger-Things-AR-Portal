using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    public GameObject testCube;
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            testCube.gameObject.SetActive(true);
            
        }
    }
}
