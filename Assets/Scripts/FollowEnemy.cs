using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowEnemy : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;


    public float range;
    public LayerMask player;
    public Transform Player;
    public bool AlertEnemy;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }
    // Update is called once per frame
    void Update()
    {
        AlertEnemy = Physics.CheckSphere(transform.position, range, player);
        if (AlertEnemy == true)
        {
            transform.LookAt(new Vector3(Player.position.x, transform.position.y, Player.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(Player.position.x, transform.position.y, Player.position.z), speed * Time.deltaTime);
        }
        if(AlertEnemy==false)
        {
            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
                UpdateDestination();
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, range);
    }




    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

}
