// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;
// public class DragAndShoot : MonoBehaviour
// {
//     [SerializeField] private float _forceMultiplier;
//     [SerializeField] private Transform _indicator;

    
//     private Vector3 _mousePressDownPos;
//     private Vector3 _mouseReleasePos;
//     private Rigidbody _rb;
//     private bool _isShoot;

//     public Transform Indicator_GO => _indicator;
//     void Start()
//     {
//         _indicator.gameObject.SetActive(false);
//         _isShoot = true;
//         _rb = GetComponent<Rigidbody>();
//     }
//     // private void Update() {
//     //     Shoot(GameManager.Instance.MouseInput.MousePressDownPos - GameManager.Instance.MouseInput.MouseReleasePos);
//     // }
//     // private void OnMouseDown() {
//     //     _mousePressDownPos = Input.mousePosition;
//     // }

//     // private void OnMouseUp() {
//     //     _mouseReleasePos = Input.mousePosition;
//     //     Debug.Log("_mouseReleasePos - _mousePressDownPos : " + (_mouseReleasePos - _mousePressDownPos));
//     //     Vector3 force = _mousePressDownPos - _mouseReleasePos;
//     //     Vector3 newForce = new Vector3(force.x, 0, force.y);
//     //     _indicator.localPosition = newForce * 0.01f;
//     //     Shoot(_mouseReleasePos - _mousePressDownPos);    
//     // }
//     public void Indicator(Vector3 dir)
//     {
//         Vector3 newForce = new Vector3(dir.x, 0, dir.y);
//         _indicator.localPosition = newForce * 0.01f;
//     }
//     public void Shoot(Vector3 force)
//     {
//         if (!_isShoot)
//             return;
//         _rb.AddForce(new Vector3(force.x, 0, force.y) * _forceMultiplier);
//         _isShoot = true;
//     }

//     public void Die(){
//         Destroy(gameObject);
//     }

//     // public void OnBeginDrag(PointerEventData eventData)
//     // {
//     //     _mousePressDownPos = Input.mousePosition;
//     // }
//     // public void OnDrag(PointerEventData eventData)
//     // {
//     //     _mouseReleasePos = Input.mousePosition;
//     //     Debug.Log("_mouseReleasePos - _mousePressDownPos : " + (_mouseReleasePos - _mousePressDownPos));
//     //     Vector3 force = _mousePressDownPos - _mouseReleasePos;
//     //     Vector3 newForce = new Vector3(force.x, 0, force.y);
//     //     _indicator.localPosition = newForce * 0.01f;
//     //     Shoot(_mouseReleasePos - _mousePressDownPos);
//     // }

// }
