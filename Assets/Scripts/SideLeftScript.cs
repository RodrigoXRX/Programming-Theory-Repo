using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

public class SideLeftScript : MonoBehaviour
{
    public bool isFlower = false;
    public bool isHuman = false;
    public bool isTree = false;
    public bool isRobot1 = false;
    public bool isRobot2 = false;
    public bool isCat = false;
    public bool isCar = false;

    public TextMeshProUGUI sucessText;
    public GameObject backgroundMessage;

    void Update()
    {
        if (isFlower && isHuman && isTree && isRobot1 && isRobot2 && isCat && isCar == true)
        {
            sucessText.gameObject.SetActive(true);
            backgroundMessage.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.Space))
            {  

            SceneManager.LoadScene("Test 2");

            }
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
