using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingChessManager : MonoBehaviour
{
    [SerializeField] private float _forceMultiplier;
    [SerializeField] private Transform _indicator;

    private Rigidbody _rb;
    private bool _isShoot;
    private GameObject _goChange;
    private List<GameObject> _listChild = new List<GameObject>();
    private Vector3 _currentScale;
    public Transform Indicator_GO => _indicator;

    void Start()
    {
        _indicator.gameObject.SetActive(false);
        _isShoot = true;
        _rb = GetComponent<Rigidbody>();
    }
    private void Update() {
        _goChange = gameObject.transform.GetChild(0).gameObject;
        _currentScale = _goChange.transform.localScale;
    }
    public void ChangeUp()
    {
        // so le tang mass va force  // so chan change GO
        _goChange.transform.localScale = new Vector3(_currentScale.x , _currentScale.y += 1f,_currentScale.z);
        _rb.mass += 1;
        _forceMultiplier += 1;

    }
    public void Indicator(Vector3 dir)
    {
        Vector3 newForce = new Vector3(dir.x, 0, dir.y);
        _indicator.localPosition = newForce * 0.01f;
    }
    public void Shoot(Vector3 force)
    {
        if (!_isShoot)
            return;
        _rb.AddForce(new Vector3(force.x, 0, force.y) * _forceMultiplier);
        _isShoot = true;
    }
    public void Die()
    {
        Destroy(gameObject);
        Debug.Log(" ------ GameOver ------");
    }
}
