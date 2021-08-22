using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    public float panSpeed = 5f;
    public Vector2 panLimit;
    public float scrollSpeed = 2f;

    private Vector3 camInitialPosition;

    private void Update()
    {
        // DragOffset();
        GetBaseInput();
    }
    // private void DragOffset()
    // {
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         camInitialPosition = cam.ScreenToWorldPoint(Input.mousePosition);
    //     }

    //     if(Input.GetMouseButton(0))
    //     {
    //         Vector3 camDragDistance = camInitialPosition - cam.ScreenToWorldPoint(Input.mousePosition);
    //         transform.position += camDragDistance;
    //     }
    // }

    private void GetBaseInput()
    {
        Vector3 pos = transform.position;
        
        if(Input.GetKey(KeyCode.W))
        {
            pos.y += panSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            pos.y -= panSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {    
            pos.x += panSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        cam.orthographicSize += scroll * scrollSpeed * 2 * Time.deltaTime;
        if(cam.orthographicSize<1)
        {
            cam.orthographicSize = 1;
        }
        if(cam.orthographicSize>10)
        {
            cam.orthographicSize = 10;
        }
        
        pos.y = Mathf.Clamp(pos.y, -panLimit.x, panLimit.x);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;
    }
    
}