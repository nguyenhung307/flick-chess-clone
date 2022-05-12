// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.AI;

// public class BotController : MonoBehaviour
// {
//     private NavMeshAgent navMeshAgent;
//     private int currentPoint;
//     public float turnSpeed;

//     public List<Transform> goal = new List<Transform>();

//     private void Awake()
//     {
//         currentPoint = 1;
//         navMeshAgent = GetComponent<NavMeshAgent>();
//         navMeshAgent.updateRotation = false;
//         navMeshAgent.speed = Random.Range(20, 35);
//     }
//     private void Update()
//     {
//         if (!CountdownTimer.Instance.gameIsStart) return;
//         Move();
//     }

//     void Move()
//     {
//         if (goal.Count == 0) return;
//         if (Vector3.Distance(goal[currentPoint].transform.position, transform.position) < 20)
//         {
//             currentPoint++;
//             if (currentPoint >= goal.Count)
//             {
//                 currentPoint = 1;
//             }
//         }
//         Vector3 turnTowardNavSteeringTarget = navMeshAgent.steeringTarget;
//         //Debug.Log(Vector3.Distance(goal[currentPoint].transform.position, transform.position) + goal[currentPoint].name);
//         Vector3 direction = (turnTowardNavSteeringTarget - transform.position).normalized;
//         Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
//         transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
//         navMeshAgent.SetDestination(goal[currentPoint].transform.position);
//     }
// }
