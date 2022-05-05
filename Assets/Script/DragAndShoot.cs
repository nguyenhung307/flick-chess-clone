using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndShoot : MonoBehaviour
{
    [SerializeField] private float forceMultiplier;
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;
    
    void Start()
    {
        isShoot = true;
        rb = GetComponent<Rigidbody>();
    }
    private void Update() {
        Debug.Log(mouseReleasePos);
    }

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot(mouseReleasePos-mousePressDownPos);
    }

    void Shoot(Vector3 Force)
    {
        if(!isShoot)    
            return;
        
        rb.AddForce(new Vector3(Force.x,Force.y,Force.y) * forceMultiplier);
        isShoot = true;
    }
    
}
