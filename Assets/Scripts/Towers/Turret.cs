using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    
    [Header("Attributes")]
    public float radius = 15f;
    public float fireRate = 5f;
    private float fireCountdown = 0f;

    [Header("Setup")]
    public Transform partToRotate;
    public GameObject bulletPrefab;
    public Transform firePoint;

    // Use this for initialization
    protected virtual void Start()
    {
        //Make sure we are always looking for a target from the first frame
        InvokeRepeating("FindTarget", 0f, 0.5f);
    }

   protected virtual void Update()
    {
        //if we have no target, do nothing
        if (target == null)
            return;
        // otherwise set the direction or rotating parts must look towards
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0, rotation.y, 0f);
        // If we have a target and are not waiting to shoot
        if (fireCountdown <= 0)
        {
            //Call the Shoot function and reset our fire rate
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        //Make sure our firerate counts down with time
        fireCountdown -= Time.deltaTime;
    }


   protected virtual void Shoot()
    {
        
        //Debug.Log("Shoot");

    }

    protected virtual void FindTarget()
    {
        //Set an array of enemies
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //Set the shortest distance of enemies to infinity so that there will always be a closer enemy
        float shortestDistance = Mathf.Infinity;
        // set our initial enemy to null
        GameObject nearestEnemy = null;
        // Then run a forloop on the array of enemies
        foreach(GameObject enemy in enemies)
        {
            //Record the distance of all enemies
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            //set our shortest distance to the closest enemy
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        // If we have an active enemy and it is within range
        if(nearestEnemy != null && shortestDistance <= radius)
        {
            // Make us target it
            target = nearestEnemy.transform;
        }
        else
        {
            //otherwise return our target to null
            target = null;
        }
    }
    protected virtual void OnDrawGizmosSelected()
    {
        //Shows our radius on the scene view when selected
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
