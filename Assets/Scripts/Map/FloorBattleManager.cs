using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBattleManager : MonoBehaviour
{
    public static FloorBattleManager Instance;
    [SerializeField] private FloorSpawnMap _spawnFloor;
    public FloorSpawnMap SpawnFloor => _spawnFloor;
    [SerializeField] private FloorSpawnMap _spawnFloor2;
    public FloorSpawnMap SpawnFloor2 => _spawnFloor2;
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