using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragndrop : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;
    [SerializeField] private float _speed =1000;
    private CameraMovement _camMove;
    public static bool _camMoveAllow = true;

    void Awake(){
        _cam = Camera.main;
        _camMove = GameObject.FindObjectOfType<CameraMovement> ();
    }

    void OnMouseDown(){
        _dragOffset = transform.position - GetMousePos();
    }

    void OnMouseDrag() {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset,_speed*Time.deltaTime );
        // bool _camMoveAllow = false;
        // _camMove.updateCamStatus(_camMoveAllow);
    }

    Vector3 GetMousePos(){
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z =0;
        return mousePos;
    }
}
