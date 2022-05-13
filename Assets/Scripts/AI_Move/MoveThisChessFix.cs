using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class MoveThisChessFix : MonoBehaviour
{
    [SerializeField] private List<Transform> _chess = new List<Transform>();
    [SerializeField] private List<Transform> destination = new List<Transform>();
    [SerializeField] private List<Transform> destinationRun1 = new List<Transform>();
    [SerializeField] private List<Transform> destination2 = new List<Transform>();
    [SerializeField] private List<Transform> destinationRun2 = new List<Transform>();


    public GameObject floorLane, floorLane2;
    public bool floorLaneActive, floorLane2Active;


    void Start()
    {
        floorLane.SetActive(false);
        floorLane2.SetActive(false);
        floorLaneActive = false;
        floorLane2Active = false;

    }


    public void moveChess()
    {
        // moveTarget = true;
        floorLane.SetActive(true);

        // _chess.DOMove(destinationRound1, 5f);
        for (int i = 0; i < _chess.Count; i++)
        {
            _chess[i].DOMove(destinationRun1[i].position, 5f)
            .OnComplete(() =>
            {
                for (int j = 0; j < _chess.Count; j++)
                {
                    _chess[j].DOMove(destination[j].position, 5f);
                }

            });
        }
        
    }

    public void moveChess2()
    {
        floorLane2.SetActive(true);

        for (int k = 0; k < _chess.Count; k++)
        {
            _chess[k].DOMove(destinationRun2[k].position, 5f)
            .OnComplete(() =>
            {
                for (int h = 0; h < _chess.Count; h++)
                {
                    _chess[h].DOMove(destination2[h].position, 5f);
                }

            });
        }
    }

}