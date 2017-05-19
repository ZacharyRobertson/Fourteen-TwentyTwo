using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyEnemy : Enemy
{

	protected override void Start()
    {
        base.Start();
    }
	void Update () {
        if (health <= 0)
        {
            Death();
        }
    }
}
