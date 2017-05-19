using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : Enemy {

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        //hard enemy health = 30
        base.health += 20;
    }

    void Update()
    {
        if (health <= 0)
        {
            Death();
        }
    }

}
