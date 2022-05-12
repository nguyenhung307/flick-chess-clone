using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMesh : MonoBehaviour
{
    private int _callTime ;
    private GameObject _go;
    [SerializeField] private List<GameObject> _listChess = new List<GameObject>();
    [SerializeField] private List<Material> _materialChess = new List<Material>();

    public List<GameObject> ListChess => _listChess;
    public List<Material> MaterialChess => _materialChess;

    private void Start() {
        _callTime  = 0;
    }
    public GameObject GetChess()
    {
        _go = _listChess[_callTime];
             _callTime ++;
        return _go ;
    }
}
