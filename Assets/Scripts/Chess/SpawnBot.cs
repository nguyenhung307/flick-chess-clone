using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBot : MonoBehaviour
{
    [SerializeField] public List<Transform> pos = new List<Transform>();
    
    private void Start() {
        GameObject goKingEnemy = Instantiate(GameManager.Instance.ListMesh.ListChess[5], pos[0].position, Quaternion.identity);
        goKingEnemy.tag = "Enemy";
        Instantiate(GameManager.Instance.ListMesh.ListChess[Random.Range(0,4)], pos[1].position, Quaternion.identity).gameObject.tag = "Enemy";
        Instantiate(GameManager.Instance.ListMesh.ListChess[Random.Range(0,4)], pos[2].position, Quaternion.identity).gameObject.tag = "Enemy";
        Instantiate(GameManager.Instance.ListMesh.ListChess[Random.Range(0,4)], pos[3].position, Quaternion.identity).gameObject.tag = "Enemy";
        Instantiate(GameManager.Instance.ListMesh.ListChess[Random.Range(0,4)], pos[4].position, Quaternion.identity).gameObject.tag = "Enemy";
        //Instantiate(GameManager.Instance.ListMesh.ListChess[Random.Range(0,4)], pos[5].position, Quaternion.identity).gameObject.tag = "Enemy";
    }
}
