using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SideLeftScript : MonoBehaviour
{
    public bool isFlower = false;
    public bool isHuman = false;
    public bool isTree = false;
    public bool isRobot1 = false;
    public bool isRobot2 = false;
    public bool isCat = false;
    public bool isCar = false;

    void FixedUpdate()
    {
        if (isFlower && isHuman && isTree && isRobot1 && isRobot2 && isCat && isCar == true)
        {
            SceneManager.LoadScene("Test 2");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flower"))
        {
            isFlower = true;
        }
        if (other.CompareTag("Tree"))
        {
            isTree = true;
        }
        if (other.CompareTag("Human"))
        {
            isHuman = true;
        }
        if (other.CompareTag("Cat"))
        {
            isCat = true;
        }
        if (other.CompareTag("Car"))
        {
            isCar = true;
        }
        if (other.CompareTag("Robot1"))
        {
            isRobot1 = true;
        }
        if (other.CompareTag("Robot2"))
        {
            isRobot2 = true;
        }
    }

}
