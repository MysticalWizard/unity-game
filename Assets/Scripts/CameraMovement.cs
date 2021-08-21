using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private Vector3 camInitialPosition;


    private void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        if(Input.GetMouseButtonDown(0))
            camInitialPosition = cam.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {
            Vector3 camDragDistance = camInitialPosition - cam.ScreenToWorldPoint(Input.mousePosition);
            cam.transform.position += camDragDistance;
        }
        if(Input.GetKey (KeyCode.W)){
            cam.transform.position += new Vector3(0, 0 , 1);
        }
        if(Input.GetKey (KeyCode.S)){
            cam.transform.position += new Vector3(0, 0, -1);
        }
        if(Input.GetKey (KeyCode.A)){
            cam.transform.position += new Vector3(-1, 0, 0);
        }
        if(Input.GetKey (KeyCode.D)){
            cam.transform.position += new Vector3(1, 0, 0);
        }
        // return cam.transform.position;
    }
    
}