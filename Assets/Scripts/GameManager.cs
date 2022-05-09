using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private MouseInput _mouseInput;
    [SerializeField] private PlayerManager _playerManager; 
    [SerializeField] private ListMesh _listMesh;
    [SerializeField] private KingChessManager _kingChess;


    public PlayerManager PlayerManager => _playerManager;
    public MouseInput MouseInput => _mouseInput;
    public ListMesh ListMesh => _listMesh;
    public KingChessManager KingChes => _kingChess;
    private void Awake() {
        if(Instance == null){
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
