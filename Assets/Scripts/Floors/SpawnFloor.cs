using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    public int floatLevel;
    private void Start()
    {
        if (floatLevel < 20)
        {
            SpawnFloorLevel();
        }
        else
        {
            SpawnFloorLevel21();
        }
    }
    public void SpawnFloorLevel()
    {
        
        Vector3 pos = _spawnPos.transform.position;

        GameObject go = Instantiate(FloorManager.Instance.ListFloor[floatLevel].gameObject);
        go.transform.position = pos;

    }
    public void SpawnFloorLevel21()
    {
        int floor = Random.Range(0, FloorManager.Instance.ListFloor.Count);
        Vector3 pos = _spawnPos.transform.position;

        GameObject go = Instantiate(FloorManager.Instance.ListFloor[floor].gameObject);
        go.transform.position = pos;
    }

}
