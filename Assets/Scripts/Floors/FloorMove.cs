using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour
{
    public GameObject floorLane, floorLane2;
    public bool floorLaneActive, floorLane2Active;

    // Start is called before the first frame update
    void Start()
    {
        floorLane.SetActive(false);
        floorLane2.SetActive(false);
        floorLaneActive = false;
        floorLane2Active = false;
        // StartRound1 = false;
        // StartRound2 = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (floorLaneActive == true)
        {
            StartGame();
        }
        else
        {
            HideFloorLane();
        }
        if (floorLane2Active == true)
        {
            GoRound();
        }
        else
        {
            HideFloorLane2();
        }
        // if (StartRound1 == true || StartRound2 == true )
        // {
        //     HideFloorLane();
        // }
    }
    public void StartGame()
    {
        floorLane.SetActive(true);
    }
    public void GoRound()
    {
        floorLane2.SetActive(true);
    }
    public void HideFloorLane()
    {
        floorLane.SetActive(false);
    }
    public void HideFloorLane2()
    {

        floorLane2.SetActive(false);
    }
    
}
