using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThisChess : MonoBehaviour
{
    public Vector3 newPosition;
    public void moveObject()
    {
        transform.position = newPosition;
    }
}
