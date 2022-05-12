using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRound : MonoBehaviour
{
    private bool _isPlayerTurn;

    public bool IsPlayerTurn
    {
        get
        {
            return _isPlayerTurn;
        }
        set
        {
            this._isPlayerTurn = value;
        }
    }
    private void Awake()
    {
        _isPlayerTurn = false;
        // StartCoroutine(CheckTurnPlayer());
    }
    private void Update() {
        if(!_isPlayerTurn){
        StartCoroutine(CheckTurnPlayer());
        }
    }
    IEnumerator CheckTurnPlayer()
    {   
            yield return new WaitForSeconds(5f);
            _isPlayerTurn = true;
    }
    public void SetIsPlay(bool isPlay){
        
        _isPlayerTurn = isPlay;
        Debug.Log("set Isplay " + _isPlayerTurn);
    }
}
