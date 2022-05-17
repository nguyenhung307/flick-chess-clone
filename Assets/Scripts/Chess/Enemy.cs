using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    private void Update()
    {
        if (gameObject.transform.position.y < 2f && gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
    public void Die()
    { 
        Destroy(gameObject);
        GameManager.Instance.ChangeUp(GameManager.Instance.RaycastCheck.Check().transform.name == "King"); // Sửa
        GameManager.Instance.ListEnemy.Remove(gameObject);
        GameManager.Instance.CheckWin();
        if (gameObject.name == "King(Clone)")
        {
            Debug.Log(" ---------- Game wwin ----------");
        }
    }
}
