using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragChess : MonoBehaviour
{

    private GridPlace grid;
    public bool isOnGrid;
    private void Start()
    {
        grid = GameManager.Instance.GridPlace;
    }

    private void Update()
    {
        if (isOnGrid)
        {
            transform.position =  grid.smoothMouse + new Vector3(0, 1, 0);
        }
    }
}
