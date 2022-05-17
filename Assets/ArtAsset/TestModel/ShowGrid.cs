using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGrid : MonoBehaviour
{

    [SerializeField] private Transform _girdCellPrefabs;
    [SerializeField] private int gridSize;
    [SerializeField] private int _height;
    [SerializeField] private int _width;
    void Start()
    {
        CreatGrid();
        gameObject.transform.position = gameObject.transform.position;
    }
    public void CreatGrid()
    {

        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < 7 - _width; j++)
            {
                Vector3 worldPos = new Vector3(i * 2, gameObject.transform.position.y, j * 2);
                Transform obj = Instantiate(_girdCellPrefabs, worldPos, Quaternion.identity);
                obj.SetParent(gameObject.transform);
            }
        }
    }

    public void AddNewGrid(){
            Vector3 worldPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.x);
            Instantiate(_girdCellPrefabs, worldPos, Quaternion.identity);
    }
}
