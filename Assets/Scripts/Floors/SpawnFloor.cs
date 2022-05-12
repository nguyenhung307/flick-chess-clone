using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    private void Start()
    {
        // StartCoroutine(IeSpawn());
        Spawn();
    }
    public void Spawn()
    {
        int floor = Random.Range(0, FloorManager.Instance.ListFloor.Count);
        Vector3 pos = _spawnPos.transform.position;

        GameObject go = Instantiate(FloorManager.Instance.ListFloor[floor].gameObject);
        go.transform.position = pos;


    }

}
