using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CamMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float distanceToTarget = 10;

    private Vector3 previousPosition;
    public TurnRound TurnRoundPlayer;

    void Update()
    {
        CameraMove();
    }
    public void Controller()
    {
        // if (TurnRoundPlayer.IsPlayerTurn == true)
        // {
        //     CameraMove();
        // }
        CameraMove();
    }
    public void CameraMove()
    {
        
        if (Input.GetMouseButtonDown(0) )
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0) )
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 60; // camera moves horizontally
            // float rotationAroundXAxis = direction.y * 60; // camera moves vertically

            cam.transform.position = target.position;

        
            // cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World);
            cam.transform.Translate(new Vector3(0, 0, -distanceToTarget));

            previousPosition = newPosition;
        }
    }
}
