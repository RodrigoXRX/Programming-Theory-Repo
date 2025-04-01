using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideRightScript : MonoBehaviour
{  
    public SideLeftScript sideLeftScript;

    void Start()
    {
        sideLeftScript = GameObject.Find("Side Left").GetComponent<SideLeftScript>();   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flower"))
        {
            sideLeftScript.isFlower = false;
        }
        if (other.CompareTag("Tree"))
        {
            sideLeftScript.isTree = false;
        }
        if (other.CompareTag("Human"))
        {
            sideLeftScript.isHuman = false;
        }
        if (other.CompareTag("Cat"))
        {
            sideLeftScript.isCat = false;
        }
        if (other.CompareTag("Car"))
        {
            sideLeftScript.isCar = false;
        }
        if (other.CompareTag("Robot1"))
        {
            sideLeftScript.isRobot1 = false;
        }
        if (other.CompareTag("Robot2"))
        {
            sideLeftScript.isRobot2 = false;
        }
    }
}
