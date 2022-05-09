using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInput : MonoBehaviour,IDragHandler, IBeginDragHandler,IEndDragHandler
{
    private Vector3 _mousePressDownPos;
    private Vector3 _mouseReleasePos;
    private Vector3 forceDir ;
    private float _currentDistance;

    public void OnBeginDrag(PointerEventData eventData)
    {
        _mousePressDownPos = Input.mousePosition;
        //GameManager.Instance.PlayerManager.Indicator_GO.gameObject.SetActive(true);
        GameManager.Instance.KingChes.Indicator_GO.gameObject.SetActive(true);
        //Debug.Log(_mousePressDownPos);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 _mouseDir = Input.mousePosition;
        float  _currentDistance1 = Vector3.Distance(_mousePressDownPos,_mouseReleasePos);
        //GameManager.Instance.PlayerManager.Indicator(_mousePressDownPos - _mouseDir);
        GameManager.Instance.KingChes.Indicator(_mousePressDownPos - _mouseDir);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _mouseReleasePos = Input.mousePosition;
        _currentDistance = Vector3.Distance(_mousePressDownPos,_mouseReleasePos);
        //Debug.Log(_currentDistance);
        if(_currentDistance < 40 || _currentDistance > 500)
        return;

        // GameManager.Instance.PlayerManager.Shoot(_mousePressDownPos - _mouseReleasePos);
        // GameManager.Instance.PlayerManager.Indicator_GO.gameObject.SetActive(false);
        GameManager.Instance.KingChes.Shoot(_mousePressDownPos - _mouseReleasePos);
        GameManager.Instance.KingChes.Indicator_GO.gameObject.SetActive(false);
        //GameManager.Instance.PlayerManager.Indicator_GO.gameObject.transform.position = new Vector3(0,0,0);
    }
}
