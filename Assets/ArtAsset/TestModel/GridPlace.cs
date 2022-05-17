using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlace : MonoBehaviour
{
    const int SIZE_GRID_WIDTH = 5;
    const int SIZE_GRID_HEIGHT = 2;

    [SerializeField] private Transform _girdCellPrefabs;
    [SerializeField] private Transform _cube;
    [SerializeField] private int gridSize;
    [SerializeField] private int _height;
    [SerializeField] private int _width;

    public Transform onMousePrefabs;

    private Node[,] nodes;
    private Plane plane;
    private Vector3 mousePos;
    public Vector3 smoothMouse;
    public int _current;
    private void Start()
    {
        CreatGrid();
        plane = new Plane(Vector3.up, transform.position); 
        gridSize = SIZE_GRID_WIDTH;
        _current = 0;
    }
    private void Update()
    {
        onMousePrefabs = GameManager.Instance.RaycastCheck.Check().transform;
        GetMousePositionOnGrid();
    }

    public void GetMousePositionOnGrid()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out var enter))
        {
            mousePos = ray.GetPoint(enter);
            smoothMouse = mousePos;
            mousePos.y = 0;
            mousePos = Vector3Int.RoundToInt(mousePos);
            foreach (var node in nodes)
            {
                if (node.cellPosition == mousePos && node.isPlaceable)
                {
                    if (Input.GetMouseButtonUp(0) && onMousePrefabs != null)
                    {
                        node.isPlaceable = false;
                        onMousePrefabs.GetComponent<DragChess>().isOnGrid = false;
                        onMousePrefabs.position = node.cellPosition + new Vector3(0, 1, 0);
                        onMousePrefabs = null;
                    }
                }
            }
        }
    }

    // public void OnMouseClickUI()
    // {
    //     if (onMousePrefabs == null)
    //     {
    //         onMousePrefabs = Instantiate(_cube, mousePos, Quaternion.identity);
    //     }
    // }
    public void AddGrid(){
        _current ++;
        nodes = new Node[SIZE_GRID_WIDTH, SIZE_GRID_HEIGHT];
        Vector3 worldPos = new Vector3(gameObject.transform.position.x + 5 , gameObject.transform.position.y, gameObject.transform.position.z + 5);
        Transform obj = Instantiate(_girdCellPrefabs, worldPos, Quaternion.identity);
        obj.SetParent(gameObject.transform);
    }
    public void CreatGrid()
    {
        nodes = new Node[SIZE_GRID_WIDTH, SIZE_GRID_HEIGHT];

        for (int i = 0; i < _width; i++)
        {
                for (int j = 0; j < _height; j++)
                {
                    Vector3 worldPos = new Vector3(i * 2, gameObject.transform.position.y, j * 2);
                    Transform obj = Instantiate(_girdCellPrefabs, worldPos, Quaternion.identity);
                    obj.SetParent(gameObject.transform);
                    nodes[i, j] = new Node(true, worldPos, obj);
                }
        }
    }

}


public class Node
{
    public bool isPlaceable;
    public Vector3 cellPosition;
    public Transform obj;
    public Node(bool isPlaceable, Vector3 cellPosition, Transform obj)
    {
        this.isPlaceable = isPlaceable;
        this.cellPosition = cellPosition;
        this.obj = obj;
    }
}