using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField]
    private float movingSpeed = 2f;
    [SerializeField]
    private GameObject[] Waypoints;
    private int curWaypointIndex = 0;

    void Update()
    {
        if(Vector2.Distance(Waypoints[curWaypointIndex].transform.position, transform.position) < 0.1f)
        {
            curWaypointIndex++;
            if(curWaypointIndex >= Waypoints.Length)
            {
                curWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[curWaypointIndex].transform.position, movingSpeed * Time.deltaTime);
    }
}
