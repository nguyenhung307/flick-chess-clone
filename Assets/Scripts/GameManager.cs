using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region  Private
    public static GameManager Instance;
    [SerializeField] private MouseInput _mouseInput;
    [SerializeField] private ListMesh _listMesh;
    [SerializeField] private RaycastCheck _raycastCheck;
    [SerializeField] private float _forceMultiplier;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private TurnRound _turnRound;

    private bool _gameIsWin;
    private GameObject _currentChose;
    private int callNum;
    private List<GameObject> _listEnemy = new List<GameObject>();
    private List<GameObject> _listChessPlayer = new List<GameObject>();


    #endregion

    #region  Public
    public ParticleSystem ParticleSystem => _particleSystem;
    public MouseInput MouseInput => _mouseInput;
    public ListMesh ListMesh => _listMesh;
    public RaycastCheck RaycastCheck => _raycastCheck;
    public List<GameObject> ListEnemy { get { return _listEnemy; } set { value = _listEnemy; } }
    public List<GameObject> ListPlayer { get { return _listChessPlayer; } set { value = _listChessPlayer; } }
    #endregion
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
        callNum = 0;
    }
    private void Start()
    {
        _listEnemy.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        _listChessPlayer.AddRange(GameObject.FindGameObjectsWithTag("Player"));
    }
    private void Update()
    {
        CheckWin(_listEnemy, _listChessPlayer);
    }
    public void Shoot(Vector3 force, Rigidbody _rb)
    {
        if (_turnRound.IsPlayerTurn)
        {
            _rb.AddForce(new Vector3(force.x, 0, force.y) * _forceMultiplier);
            // _turnRound.SetIsPlay(false); 
            _turnRound.ChangeTeam(false);
        }
    }
    public void ChangeUp(bool isKing)
    {
        // so le tang mass va force  // so chan change GO
        _currentChose = RaycastCheck.Check().transform.gameObject;
        Vector3 _currentPos = _currentChose.transform.position;

        _forceMultiplier += 1;
        _currentChose.GetComponent<Rigidbody>().mass += 1;

        if (isKing)
        {
            _currentChose.transform.localScale = new Vector3(_currentChose.transform.localScale.x + 0.1f, _currentChose.transform.localScale.y + 0.1f, _currentChose.transform.localScale.z + 0.1f);
        }
        else
        {
            Destroy(_currentChose);
            GameObject _go = Instantiate(GameManager.Instance.ListMesh.GetChess(), _currentPos, Quaternion.identity);
            // _go.transform.SetParent(gameObject.transform);
            // _go.transform.localScale = new Vector3(1.5f, 4,1.5f);
            _go.SetActive(true);
            // _go.transform.SetSiblingIndex(0);
        }
    }
    public void CheckWin(List<GameObject> listEnemy, List<GameObject> _listPlayer)
    {
         //Debug.Log(" So quan Enemy :" + _listPlayer.Count);
        if (listEnemy.Count == 0)
        {
            foreach (var item in _listPlayer)
            {
                Instantiate(_particleSystem, item.transform.position, Quaternion.identity);
            }
        
            Debug.Log(" ------ Win game ------- ");
        }

      //Debug.Log(" So quan con song :" + _listPlayer.Count);
    }
}
