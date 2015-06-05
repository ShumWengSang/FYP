using UnityEngine;
using System.Collections;
using Pathfinding;

public class BasicAI : MonoBehaviour {

    //Vector3 targetPosition;
    //public GameObject targetObject;

    //private Seeker seeker;
    //private CharacterController controller;
    ////The calculated path
    //public Path path;

    ////The AI's speed per second
    //public float speed = 100;

    ////The max distance from the AI to a waypoint for it to continue to the next waypoint
    //public float nextWaypointDistance = 3;

    ////The waypoint we are currently moving towards
    //private int currentWaypoint = 0;

    //public void Start()
    //{
    //    //Get a reference to the Seeker component we added earlier
    //    seeker = GetComponent<Seeker>();
    //    controller = GetComponent<CharacterController>();
    //    targetPosition = targetObject.transform.position;
    //    //Start a new path to the targetPosition, return the result to the OnPathComplete function
    //    seeker.StartPath(transform.position, targetPosition, OnPathComplete);
    //}

    //public void OnPathComplete(Path p)
    //{
    //    Debug.Log("Yay, we got a path back. Did it have an error? " + p.error);
    //    if (!p.error)
    //    {
    //        path = p;
    //        //Reset the waypoint counter
    //        currentWaypoint = 0;
    //    }
    //}

    //public void FixedUpdate()
    //{
    //    targetPosition = targetObject.transform.position;
    //    if (path == null)
    //    {
    //        //We have no path to move after yet
    //        return;
    //    }

    //    if (currentWaypoint >= path.vectorPath.Count)
    //    {
    //        return;
    //    }
    //    //Direction to the next waypoint
    //    Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized;
    //    dir *= speed * Time.fixedDeltaTime;
    //    controller.SimpleMove(dir);

    //    //Check if we are close enough to the next waypoint
    //    //If we are, proceed to follow the next waypoint
    //    if (Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]) < nextWaypointDistance)
    //    {
    //        currentWaypoint++;
    //        return;
    //    }
    //}

    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
