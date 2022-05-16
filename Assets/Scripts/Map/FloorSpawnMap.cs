using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnMap : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    public int floorLevel;
    private void Start()
    {
        SpawnFloorLevel20();
        // SpawnFloorLevel();
    }

    public void SpawnFloorLevel20()
    {
        Vector3 pos = _spawnPos.transform.position;

        GameObject go = Instantiate(FloorManager.Instance.ListFloor[0].gameObject);
        go.transform.position = pos;
    }
    public void SpawnFloorRandom()
    {
        int floor = Random.Range(0, FloorManager.Instance.ListFloor.Count);
        Vector3 pos = _spawnPos.transform.position;

        GameObject go = Instantiate(FloorManager.Instance.ListFloor[floor].gameObject);
        go.transform.position = pos;
    }
}
