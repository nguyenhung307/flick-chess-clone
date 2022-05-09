using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class Grapping : MonoBehaviour
{
    //private GrapInput grapInput;
    private Transform _selected;
    private bool _selecting = false;
    private float mZCoord;
    private Vector3 _mOffSet;
    private Camera camera;
    private Ray ray;
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        //grapInput = new GrapInput();
        //grapInput.Mouse.Enable();
        //grapInput.Mouse.LeftClick.started += OnLeftClick;
        //grapInput.Mouse.LeftClick.canceled += OnLeftClickRelease;
    }
    private void OnMouseDown()
    {
        Debug.Log("ok");
        mousePressDownPos = Input.mousePosition;
        if(_selecting == false) { 
            Vector2 pos = mousePressDownPos;
            ray = camera.ScreenPointToRay(pos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Transform selection = hit.transform;
                if (selection.tag == "Chess")
                {
                    _selecting = true;
                    _selected = hit.transform;
                }
            }
        }
    }

    private void MovingSelectedOldInput()
    {
        if(_selecting == true)
        {
            mZCoord = camera.WorldToScreenPoint(_selected.transform.position).z;
            Vector2 pos = Input.mousePosition;
            Vector3 mousePositionForObject = new Vector3(pos.x, pos.y, mZCoord);
            _mOffSet = camera.ScreenToWorldPoint(mousePositionForObject );
            _selected.transform.position = _mOffSet;
        }
    }
    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        _selecting = false;
        
    }
    /*
    private void OnLeftClickRelease(InputAction.CallbackContext context)
    {
        _selecting = false;
        UpgradCollideCheck();
        //_selected = null;
    }
    private void UpgradCollideCheck()
    {
        Collider[] hitColliders = Physics.OverlapSphere(_selected.transform.position, 40);
       
        float distance = 9000;
        int c = -1 ;
        
        for (int i =0; i< hitColliders.Length; i++)
        {
            if (hitColliders[i].tag == "Chess" && hitColliders[i].name != _selected.name)
            {
                float newDistance = (_selected.transform.position - hitColliders[i].transform.position).magnitude;
                if(newDistance< distance)
                {
                        distance = newDistance;
                        c = i;

                }
            }
        }   
        if(c >=0 )
        {
            hitColliders[c].GetComponent<SwitchingLevels>().CombineChess(_selected);
        }
       
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
    */
    // Update is called once per frame
    void Update()
    {
        //MovingSelected();
        MovingSelectedOldInput();
    }

}
