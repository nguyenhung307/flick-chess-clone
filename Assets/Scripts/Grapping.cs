using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grapping : MonoBehaviour
{
    private GrapInput grapInput;
    private Transform _selected;
    private bool _selecting = false;
    private float mZCoord;
    private Vector3 _mOffSet;
    private Camera camera;
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        grapInput = new GrapInput();
        grapInput.Mouse.Enable();
        grapInput.Mouse.LeftClick.started += OnLeftClick;
        grapInput.Mouse.LeftClick.canceled += OnLeftClickRelease;
    }

    private void OnLeftClickRelease(InputAction.CallbackContext context)
    {
        _selecting = false;
    }

    private void OnLeftClick(InputAction.CallbackContext context)
    {
        Vector2 pos = grapInput.Mouse.Position.ReadValue<Vector2>();
        ray = camera.ScreenPointToRay(pos);
        RaycastHit hit;
        if( Physics.Raycast(ray, out hit))
        {
            Transform selection = hit.transform;
            if (selection.tag == "Chess")
            {
                _selecting = true;
                _selected = hit.transform;
            }
        }
    }
    private void MovingSelected()
    {
        if (_selecting == true)
        {
            mZCoord =camera.WorldToScreenPoint(_selected.transform.position).z;
            Vector2 pos = grapInput.Mouse.Position.ReadValue<Vector2>();
            Vector3 mousePosition = new Vector3(pos.x, pos.y, mZCoord);
            _mOffSet = camera.ScreenToWorldPoint(mousePosition);
            _selected.transform.position =  _mOffSet;
        }    
    }
    // Update is called once per frame
    void Update()
    {
        MovingSelected();
    }
}
