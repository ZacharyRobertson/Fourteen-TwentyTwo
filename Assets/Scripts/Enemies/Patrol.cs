using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float movementSpeed = 20f;
    public Transform[] Waypoints;

    private int currentPoint = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (transform.position == Waypoints[currentPoint].position)
        {
            currentPoint++;
        }
        if (currentPoint >= Waypoints.Length)
        {
            currentPoint = 0;
        }

        Vector3 movePos = Vector3.MoveTowards(transform.position, Waypoints[currentPoint].position, movementSpeed * Time.deltaTime);
        transform.position = movePos;

    }

    void OnTriggerEnter(Collider col)
    {
        //Check if enemy collides with Goal
        if (col.tag == "Goal")
        {
            //game over
            //GameManager.Gameover();
           Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
