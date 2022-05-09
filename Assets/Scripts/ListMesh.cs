using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMesh : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listChess = new List<GameObject>();
    [SerializeField] private List<Material> _materialChess = new List<Material>();

    public List<GameObject> ListChess => _listChess;
    public List<Material> MaterialChess => _materialChess;

    public GameObject GetChess(int number )
    {
        return _listChess[number];
    }
}
