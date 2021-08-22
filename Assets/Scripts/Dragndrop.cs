using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragndrop : MonoBehaviour
{
    private bool isDragging;
    public static bool camLock;

    void Start()
    {
        camLock = false;
    }
    public void OnMouseDown()
    {
        isDragging = true;
        camLock = true;
        string status = camLock.ToString();
        Debug.Log("Mouse down" + status);
    }

    public void OnMouseUp()
    {
        isDragging = false;
        camLock = false;
        string status = camLock.ToString();
        Debug.Log("Mouse up" + status);
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

    // [SerializeField]
    // private Camera cam;

    // public static bool camLock = false;
    // private Vector3 camInitialPosition;

    // private void Update()
    // {
    //     DragOffset();

    // }

    // private void DragOffset()
    // {
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         // camInitialPosition = cam.ScreenToWorldPoint(Input.mousePosition);
    //         // camLock = false;
    //         // Debug.Log(camLock);
    //         OnMouseEnter();
    //     }

    //     if(Input.GetMouseButton(0))
    //     {
    //         // Vector3 camDragDistance = camInitialPosition - cam.ScreenToWorldPoint(Input.mousePosition);
    //         // transform.position += camDragDistance;
    //         // camLock = true;
    //         OnMouseExit();
    //     }
    // }
    // void OnMouseEnter()
    // {
    //     camInitialPosition = cam.ScreenToWorldPoint(Input.mousePosition);
    //     camLock = false;
    //     // Debug.Log(camLock);
    // }
    // void OnMouseExit()
    // {
    //     Vector3 camDragDistance = camInitialPosition - cam.ScreenToWorldPoint(Input.mousePosition);
    //     transform.position -= camDragDistance / 5;
    //     camLock = true;
    // }
    // private Vector3 _dragOffset;
    // private Camera _cam;
    // [SerializeField]
    // private float _speed =1000;
    // private CameraMovement _camMove;
    // public static bool _camMoveAllow = true;

    // void Awake(){
    //     _cam = Camera.main;
    //     _camMove = GameObject.FindObjectOfType<CameraMovement> ();
    // }

    // void OnMouseDown(){
    //     _dragOffset = transform.position - GetMousePos();
    // }

    // void OnMouseDrag() {
    //     transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset,_speed*Time.deltaTime );
    //     bool _camMoveAllow = false;
    //     _camMove.updateCamStatus(_camMoveAllow);
    // }

    // Vector3 GetMousePos(){
    //     var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
    //     mousePos.z =0;
    //     return mousePos;
    // }
}
