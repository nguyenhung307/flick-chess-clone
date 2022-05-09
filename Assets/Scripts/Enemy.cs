using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update() {
        if(gameObject.transform.position.y < -3){
            EnemyDie();
        }
    }
    public void EnemyDie()
    {
        Destroy(gameObject);
        //GameManager.Instance.PlayerManager.ChangeUp();
        GameManager.Instance.KingChes.ChangeUp();
    }
}
