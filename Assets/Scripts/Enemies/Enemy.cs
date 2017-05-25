using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [Header("Enemy")]
    public float health = 10f;
    public float attackPower = 10f;
    // use this later when we're not using the waypoints 
    // public float speed = 10f;
    public Patrol patrol;
    public GameObject[] slushie;
    public SlushieMachine slushieSlow;
    public float oldSpeed;

    protected virtual void Start()
    {
        patrol = GetComponent<Patrol>();
        slushie = GameObject.FindGameObjectsWithTag("Slushie");
        slushieSlow = slushie[0].GetComponentInParent<SlushieMachine>();
        
    }

    protected virtual void Update()
    {

        if (health <= 0)
        {
            Death();
        }
        
    }

    public virtual void Attack()
    {
        print("Enemy Attacks!");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            TakeBulletDamage();
        }

        if (other.tag == "Slushie")
        {
            oldSpeed = patrol.movementSpeed;

            Debug.Log("We Hit the Slushie");
            patrol.movementSpeed -= slushieSlow.slowSpeed;
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Slushie")
        {
            patrol.movementSpeed = oldSpeed;
        }
    }
    public void TakeBulletDamage()
    {
        health -= 10;
        Debug.Log("Bullet hit");

    }

    public void Death()
    {
        Destroy(gameObject);
        print("Enemy Died!");
    }
}
