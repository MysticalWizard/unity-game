using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragndrop : MonoBehaviour
    {
        private Vector3 _dragOffset;
        private Camera _cam;
        [SerializeField]
        private float _speed = 1000;
        void Awake()
        {
            _cam = Camera.main;
        }
        void OnMouseDown()
        {
            _dragOffset = transform.position - GetMousePos();
        }
        void OnMouseDrag()
        {
            transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * Time.deltaTime);
        }

        Vector3 GetMousePos()
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            return mousePos;
        }












        // private bool isDragging;

        // public void OnMouseDown()
        // {
        //     isDragging = true;
        // }

        // public void OnMouseUp()
        // {
        //     isDragging = false;
        // }

        // void Update()
        // {
        //     if (isDragging) {
        //         Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //         transform.Translate(mousePosition);
        //     }
        // }
    }