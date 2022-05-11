using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    public static FloorManager Instance;
    [SerializeField] private SpawnFloor _spawnFloor;
    public SpawnFloor SpawnFloor => _spawnFloor;
    [SerializeField] private SpawnFloor _spawnFloor2;
    public SpawnFloor SpawnFloor2 => _spawnFloor2;
    [SerializeField] private List<Floor> _listFloor = new List<Floor>();
    public List<Floor> ListFloor => _listFloor;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

