using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessController : MonoBehaviour
{
    private Vector3 _colliderPos;
    private void Update() {
        if((gameObject.transform.position.y < -3f) && gameObject.CompareTag("Player")){
            Debug.Log("Player Die ");
            PlayerDie();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Ground"))
        {
            ContactPoint contact = other.contacts[0];
            _colliderPos = contact.point;
            //Debug.Log(" Position on collider : " + _colliderPos);
            Instantiate(GameManager.Instance.ParticleSystem, _colliderPos, Quaternion.identity);
        }
    }

    private void PlayerDie()
    {
        Destroy(gameObject);
        GameManager.Instance.ListPlayer.Remove(gameObject);
        if(gameObject.name == "King" ){
            Debug.Log(" ---------- Game Lose ----------");
        }
    }
}
