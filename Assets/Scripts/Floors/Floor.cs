using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject Barrier;
    public bool ControlBarrier;
    public MoveThisChessFix roundGame1,roundGame2;

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
        StartCoroutine(CountdownToStart1());
        if (ControlBarrier == true)
        {
            Barrier.SetActive(true);
        }
        else
        {
            Barrier.SetActive(false);
        }
    }
    IEnumerator CountdownToStart1()
    {
        yield return new WaitForSeconds(6f);
        roundGame1.Round1Play = true;
    }IEnumerator CountdownToStart2()
    {
        yield return new WaitForSeconds(6f);
        roundGame2.Round2Play = true;
    }
}
