using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public bool _occupied = false;
    // Start is called before the first frame update
    private void Update() {
        if(_occupied){
            
                GetComponent<MeshRenderer>().material = GameManager.Instance.Material;
        }
    }

}
