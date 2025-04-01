using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed = 1.0f;

    private Camera cam;
    private bool isDragging = false;
    private Vector3 offset;
   
    
    void Start()
    {
        cam = Camera.main;         
    }

    void OnMouseDown()
    {
        isDragging = true;

        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0);   

        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.WorldToScreenPoint(transform.position).z; 

        return Camera.main.ScreenToWorldPoint(mousePos);
    }    
}

    
