using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;

    [Header("Camera Settings")]
    public float CameraSpeed;
    
     void Start()
    {
        CameraPosition = this.transform.position; 
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            CameraPosition.y -= CameraSpeed / 50;
        }
        if(Input.GetKey(KeyCode.S))
        {

            CameraPosition.y += CameraSpeed / 50;
        }
        if (Input.GetKey(KeyCode.A))
        {

            CameraPosition.x += CameraSpeed / 50;
        }
        if (Input.GetKey(KeyCode.D))
        {

            CameraPosition.x -= CameraSpeed / 50;
        }

        this.transform.Rotate(CameraPosition); 
    }
}
