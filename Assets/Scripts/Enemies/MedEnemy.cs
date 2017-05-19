using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedEnemy : Enemy
{
    protected override void Start()
    {
        base.Start();
        //med enemy health = 20
        base.health += 10;
    }

    void Update()
    {
        if (health <= 0)
        {
            Death();
        }
    }
}
