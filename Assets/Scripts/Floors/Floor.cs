using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject Barrier;
    public bool ControlBarrier;

    void Start()
    {
        ControlBarrier = false;
        Barrier.SetActive(false);
        
    }
    private void Update()
    {
        ControllerBarrier();
    }
    void ControllerBarrier()
    {
        if (ControlBarrier == true)
        {
            Barrier.SetActive(true);
        }
        else
        {
            Barrier.SetActive(false);
        }
    }
    



}
